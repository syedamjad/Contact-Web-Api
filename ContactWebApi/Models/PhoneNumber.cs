﻿namespace ContactWebApi.Models
{
    public class PhoneNumber
    {
        public int Id { get; set; }

        public string Number { get; set; }

        public Contact Contact { get; set; }
    }
}
