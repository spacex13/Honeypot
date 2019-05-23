﻿using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Honeypot.Models.MappingModels;

namespace Honeypot.Models
{
    public class Bookshelf
    {
        public Bookshelf()
        {
            this.Books = new List<BookBookshelf>();
        }

        public int Id { get; set; }

        public string Title { get; set; }

        public ICollection<BookBookshelf> Books { get; set; }

        [ForeignKey("User")]
        public string UserId { get; set; }
        public virtual HoneypotUser User { get; set; }
    }
}