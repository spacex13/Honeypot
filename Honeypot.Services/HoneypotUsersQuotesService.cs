﻿using Honeypot.Data;
using System.Linq;

namespace Honeypot.Services
{
    public class HoneypotUsersQuotesService : BaseService
    {
        public HoneypotUsersQuotesService(HoneypotDbContext context) : base(context) { }

        public bool HasUserLikedQuote(int quoteId, string userId)
        {
            if (this.context.UsersQuotes.Any(x => x.UserId == userId && x.QuoteId == quoteId))
                return true;

            return false;
        }
    }
}
