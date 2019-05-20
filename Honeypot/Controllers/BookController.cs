﻿using AutoMapper;
using Honeypot.Data;
using Honeypot.Models;
using Honeypot.Models.MappingModels;
using Honeypot.Services;
using Honeypot.ViewModels.Book;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Linq;

namespace Honeypot.Controllers
{
    //TODO: make methods smaller by using abstraction/services w/ functionality
    [Authorize]
    public class BookController : Controller
    {
        private readonly IMapper mapper;
        private readonly HoneypotDbContext context;
        private readonly HoneypotUsersService usersService;

        public BookController(IMapper mapper, HoneypotDbContext context, HoneypotUsersService usersService)
        {
            this.mapper = mapper;
            this.context = context;
            this.usersService = usersService;
        }

        [AllowAnonymous]
        public IActionResult Details(int id)
        {
            var bookResult = this.context.Books.FirstOrDefaultAsync(x => x.Id == id).Result;

            if (bookResult == null)
            {
                return this.NotFound("No such book found.");
            }

            var author = this.context.Authors.FirstOrDefaultAsync(a => a.Id == bookResult.AuthorId).Result;

            //TODO: use mapping
            var book = new BookDetailsViewModel()
            {
                Id = bookResult.Id,
                Title = bookResult.Title,
                Summary = bookResult.Summary,
                AuthorName = author.FirstName + " " + author.LastName,
                AuthorId = bookResult.AuthorId,
                Rating = bookResult.AverageRating(),
                ReviewsCount = bookResult.RatingsCount(),
                Quotes = bookResult.Quotes
            };

            return View(book);
        }

        [Authorize(Roles = "Admin")]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [Authorize(Roles = "Admin")]
        public IActionResult Create(CreateViewModel viewModel)
        {
            if (!ModelState.IsValid)
            {
                return this.View(viewModel);
            }

            var bookAuthor = this.context.Authors.FirstOrDefaultAsync(x =>
                x.FirstName == viewModel.AuthorFirstName && x.LastName == viewModel.AuthorLastName).Result;

            if (bookAuthor == null)
            {
                return this.BadRequest("Author doesn't exist!");
            }

            var bookTitle = viewModel.Title.Trim();
            var bookSumary = viewModel.Summary.Trim();

            var book = new Book(bookTitle, bookSumary, bookAuthor.Id);

            var bookExists = this.context.Books
                .FirstOrDefaultAsync(x => x.Title == book.Title && x.AuthorId == book.AuthorId).Result;

            if (bookExists != null)
            {
                return this.BadRequest("Book already exists!");
            }

            bookAuthor.Books.Add(book);
            this.context.Books.AddAsync(book);
            this.context.SaveChanges();

            return RedirectToAction("Details", "Book", new { id = book.Id });
        }

        [HttpPost]
        public IActionResult AddToBookshelf(int BookshelfId, int BookId)
        {
            var bookResult = this.context.Books.FirstOrDefaultAsync(x => x.Id == BookId).Result;

            if (bookResult == null)
            {
                return this.BadRequest("Book doesn't exist!");
            }

            var user = this.usersService.GetByUsername(this.User.Identity.Name);

            var bookshelfResult = this.context.Bookshelves.Where(x => x.UserId == user.Id).FirstOrDefaultAsync(x => x.Id == BookshelfId).Result;

            if (bookshelfResult == null)
            {
                return this.BadRequest("Bookshelf doesn't exist!");
            }

            if (this.context.BooksBookshelves.Any(x => x.BookId == BookId && x.BookshelfId == BookshelfId))
            {
                return this.BadRequest("Book is already on that bookshelf!");
            }

            var bookBookshelf = new BookBookshelf()
            {
                BookId = bookResult.Id,
                BookshelfId = BookshelfId
            };

            user.CustomBookshelves.First(x => x.Id == BookshelfId).Books.Add(bookBookshelf);
            this.context.SaveChanges();

            return RedirectToAction("Details", "Bookshelf", new { id = BookshelfId });
        }

        [HttpPost]
        public IActionResult Rate(int stars, int BookId)
        {
            var book = this.context.Books.FirstOrDefaultAsync(x => x.Id == BookId).Result;
            if (book == null)
            {
                return this.BadRequest("Book is invalid!");
            }

            if (stars < 1 || stars > 5)
            {
                return this.BadRequest("Rating is invalid!");
            }

            var user = this.usersService.GetByUsername(this.User.Identity.Name);

            if (this.context.Ratings.Any(x => x.BookId == BookId && x.UserId == user.Id))
            {
                var rating = this.context.Ratings.FirstOrDefaultAsync(x => x.BookId == BookId && x.UserId == user.Id).Result;
                rating.Stars = stars;
            }
            else
            {
                var rating = new Rating() { Stars = stars, UserId = user.Id };
                this.context.Books.FirstOrDefaultAsync(x => x.Id == BookId).Result.Ratings.Add(rating);
            }

            this.context.SaveChanges();

            return RedirectToAction("Details", new { id = book.Id });
        }
    }
}