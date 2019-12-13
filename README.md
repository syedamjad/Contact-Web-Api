# Contact Web Api

This Web Api uses .Net core 3.0

Steps to configure in development environment

1. Clone the respository or download as zip.
2. Open in Visual studio 2019 or any version.
3. Change the connection string in appsettings.json file like server name, username and password
4. Go to Package Manager Console to create database -> type "Update-Database" command in the console.
5. Cross check that database is created successfully

Database Entities

Contact Entity

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
    
    EMail Entity
    
    public class EmailEntity
    {
        [Key]
        public int Id { get; set; }

        public string MailAddress { get; set; } 

        public ContactEntity ContactEntity { get; set; }
    }
    
    PhoneNumber Entity
    
    public class PhoneNumberEntity
    {
        [Key]
        public int Id { get; set; }

        public string Number { get; set; }

        public ContactEntity ContactEntity { get; set; }
    }

