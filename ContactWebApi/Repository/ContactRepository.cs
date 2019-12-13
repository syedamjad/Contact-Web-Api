namespace ContactWebApi.Repository
{
    using AutoMapper;
    using AutoMapper.QueryableExtensions;
    using Dal;
    using Entity;
    using Models;
    using Microsoft.EntityFrameworkCore;
    using Microsoft.Extensions.Configuration;
    using System.Collections.Generic;
    using System.Linq;
    
    public class ContactRepository : IContactRepository
    {
        private readonly ContactContext contactContext;

        public ContactRepository(IConfiguration configuration)
        {
            var optionsBuilder = new DbContextOptionsBuilder<ContactContext>();
            optionsBuilder.UseSqlServer(configuration["ConnectionString:ContactDB"]);
            this.contactContext = new ContactContext(optionsBuilder.Options);
        }
        public IEnumerable<Contact> GetContacts()
        {
            return this.contactContext
                .Contacts
                .ProjectTo<Contact>(config1)
                .ToList();
        }

        public void Save(Contact contact)
        {
            if (contact.Id > 0)
            {
                var mapper = config.CreateMapper();
                var entity = this.contactContext.Contacts.FirstOrDefault(item => item.Id.Equals(contact.Id));
                entity = mapper.Map(contact, entity);
                this.contactContext.Contacts.Add(entity);
                this.contactContext.SaveChanges();
            }
            else
            {
                var mapper = config.CreateMapper();
                var entity = mapper.Map(contact, new ContactEntity());
                _ = this.contactContext.Contacts.Add(entity);
                _ = this.contactContext.SaveChanges();
            }
        }

        private static MapperConfiguration config1 = new MapperConfiguration(cfg =>
        {
            cfg.CreateMap<ContactEntity, Contact>();
            cfg.CreateMap<EmailEntity, Email>();
            cfg.CreateMap<PhoneNumberEntity, PhoneNumber>();
        });

        static MapperConfiguration config = new MapperConfiguration(cfg =>
        {
            cfg.CreateMap<Contact, ContactEntity>();
            cfg.CreateMap<Email, EmailEntity>();
            cfg.CreateMap<PhoneNumber, PhoneNumberEntity>();
        });
    }
}
