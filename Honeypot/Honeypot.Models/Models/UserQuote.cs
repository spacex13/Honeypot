﻿namespace Honeypot.Models.MappingModels
{
    public class UserQuote
    {
        public int QuoteId { get; set; }
        public Quote Quote { get; set; }

        public string UserId { get; set; }
        public HoneypotUser User { get; set; }
    }
}