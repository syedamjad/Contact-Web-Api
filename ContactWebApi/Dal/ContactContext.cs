using System;
using System.Collections.Generic;
using System.Text;
using ContactWebApi.Entity;
using Microsoft.EntityFrameworkCore;

namespace ContactWebApi.Dal
{
    public class ContactContext : DbContext
    {
        public ContactContext(DbContextOptions dbContextOptions) : base(dbContextOptions)
        {
        }

        //public ContactContext() : base()
        //{
        //}

        public DbSet<ContactEntity> Contacts { get; set; }

        public DbSet<EmailEntity> Emails { get; set; }

        public DbSet<PhoneNumberEntity> PhoneNumbers { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }
    }
}
