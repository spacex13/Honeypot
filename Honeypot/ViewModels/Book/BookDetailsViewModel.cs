﻿using System.Collections.Generic;
using System.ComponentModel;
using Honeypot.Models;

namespace Honeypot.ViewModels.Book
{
    public class BookDetailsViewModel
    {
        public string Title { get; set; }

        public string Author { get; set; }

        public int AuthorId { get; set; }

        public string Summary { get; set; }

        [DisplayName("Reviews Count")]
        public int ReviewsCount { get; set; }

        public decimal Rating { get; set; }

        public ICollection<Review> Reviews { get; set; }
    }
}