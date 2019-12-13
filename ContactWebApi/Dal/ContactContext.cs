namespace ContactWebApi.Dal
{
    using Entity;
    using Microsoft.EntityFrameworkCore;

    public class ContactContext : DbContext
    {
        public ContactContext(DbContextOptions dbContextOptions) : base(dbContextOptions)
        {
        }

        public DbSet<ContactEntity> Contacts { get; set; }

        public DbSet<EmailEntity> Emails { get; set; }

        public DbSet<PhoneNumberEntity> PhoneNumbers { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }
    }
}
