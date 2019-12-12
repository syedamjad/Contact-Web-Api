using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace ContactWebApi.Entity
{
    public class ContactEntity
    {
        [Key]
        public int Id { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public DateTime DateOfBirth { get; set; }

        public List<EmailEntity> Emails { get; set; }

        public List<PhoneNumberEntity> PhoneNumbers { get; set; }
    }
}
