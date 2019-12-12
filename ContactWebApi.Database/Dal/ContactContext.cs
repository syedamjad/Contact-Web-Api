using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Text;
using ContactWebApi.Database.Entity;

namespace ContactWebApi.Database.Dal
{
    public class ContactContext : DbContext
    {
        public ContactContext() : base("ContactContext")
        {
            //Database.SetInitializer(new DropCreateDatabaseAlways<ContactContext>());
        }

        public DbSet<ContactEntity> Contacts { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }
    }
}
