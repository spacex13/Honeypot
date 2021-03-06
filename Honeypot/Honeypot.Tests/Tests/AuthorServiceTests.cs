﻿using System.Linq;
using Honeypot.Services.Contracts;
using Honeypot.Tests.Account;
using Honeypot.Tests.Tests;
using Xunit;

namespace Honeypot.Tests
{
    public class AuthorServiceTests : BaseTest
    {
        private readonly IAuthorService authorService;

        public AuthorServiceTests(BaseTestFixture fixture) : base(fixture)
        {
            this.authorService = fixture.Provider.GetService(typeof(IAuthorService)) as IAuthorService;
            this.SeedData();
        }

        private void SeedData()
        {
            this.DeleteAuthorsData();
            this.CreateAuthorData();
        }

        [Fact]
        public void AuthorExists_ShouldReturnTrue_WhenAuthorExists()
        {
            var resultFromService = this.authorService.AuthorExists(TestsConstants.FirstName, TestsConstants.LastName);
            Assert.True(resultFromService);
        }

        [Fact]
        public void AuthorExists_ShouldReturnFalse_WhenAuthorDoesntExists()
        {
            var resultFromService = this.authorService.AuthorExists(TestsConstants.FirstNameNonExistent, TestsConstants.LastNameNonExistent);
            Assert.False(resultFromService);
        }

        [Fact]
        public void GetAuthorById_ShouldReturnAuthor()
        {
            var author = this.authorService.GetAuthorById(TestsConstants.Id1);
            Assert.Equal(TestsConstants.Id1, author.Id);
        }

        [Fact]
        public void GetAllAuthors_ShouldReturnAllAuthors()
        {
            var authorsFromService = this.authorService.GetAllAuthors();
            var correctAuthors = this.context.Authors.ToList();
            Assert.Equal(correctAuthors, authorsFromService);
        }

        [Fact]
        public void GetAuthorByName_ShouldReturnAuthor()
        {
            var authorFromService =
                this.authorService.GetAuthorByName(TestsConstants.FirstName, TestsConstants.LastName);
            var correctAuthor = this.context.Authors.FirstOrDefault(x =>
                x.FirstName == TestsConstants.FirstName && x.LastName == TestsConstants.LastName);

            Assert.Equal(correctAuthor, authorFromService);
        }
    }
}