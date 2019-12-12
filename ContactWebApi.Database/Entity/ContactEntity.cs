using System;
using System.Collections.Generic;
using System.Text;

namespace ContactWebApi.Database.Entity
{
    public class ContactEntity
    {
        public int Id { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public DateTime DateOfBirth { get; set; }

        public List<string> Emails { get; set; }

        public List<string> PhoneNumbers { get; set; }
    }
}
