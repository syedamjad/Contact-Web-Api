using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using ContactWebApi.Models;

namespace ContactWebApi.Repository
{
    public interface IContactRepository
    {
        IEnumerable<Contact> GetContacts();

        void Save(Contact contact);
    }
}
