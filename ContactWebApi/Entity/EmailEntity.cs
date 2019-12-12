﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ContactWebApi.Entity
{
    public class EmailEntity
    {
        [Key]
        public int Id { get; set; }

        public string MailAddress { get; set; } 

        public ContactEntity ContactEntity { get; set; }
    }
}