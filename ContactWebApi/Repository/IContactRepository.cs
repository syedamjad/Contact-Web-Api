namespace ContactWebApi.Repository
{
    using Models;
    using System.Collections.Generic;
    
    public interface IContactRepository
    {
        IEnumerable<Contact> GetContacts();

        void Save(Contact contact);
    }
}
