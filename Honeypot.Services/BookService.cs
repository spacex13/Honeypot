﻿using System.Linq;
using Honeypot.Data;
using Honeypot.Models;
using Honeypot.Services.Contracts;

namespace Honeypot.Services
{
    public class BookService : BaseService, IBookService
    {
        public BookService(HoneypotDbContext context) 
            : base(context)
        {
        }

        public Book GeBookById(int id)
        {
            var book = this.context.Books
                .FirstOrDefault(x => x.Id == id);

            return book;
        }

        public bool BookTitleExists(string title, string authorFirstName, string authorLastName)
        {
            var book = this.context.Books
                .FirstOrDefault(x => x.Title == title && x.Author.FirstName == authorFirstName && x.Author.LastName == authorLastName);

            var bookExists = (book != null);
            return bookExists;
        }
    }
}