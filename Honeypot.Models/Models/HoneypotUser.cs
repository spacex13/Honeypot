﻿using System.Collections.Generic;
using Honeypot.Models.Contracts;
using Honeypot.Models.MappingModels;
using Microsoft.AspNetCore.Identity;

namespace Honeypot.Models
{
    public class HoneypotUser : IdentityUser, IPerson
    {
        public HoneypotUser()
        {
            this.LikedQuotes = new List<UserQuote>();
            this.CustomBookshelves = new List<Bookshelf>();
        }

        public string FirstName { get; private set; }

        public string LastName { get; private set; }

        public virtual ICollection<Bookshelf> CustomBookshelves { get; set; }

        public virtual ICollection<UserQuote> LikedQuotes { get; set; }
    }
}
