using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ContactWebApi.Models
{
    public class PhoneNumber
    {
        public int Id { get; set; }

        public string Number { get; set; }

        public Contact Contact { get; set; }
    }
}
