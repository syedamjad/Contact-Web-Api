namespace ContactWebApi.Entity
{
    using System.ComponentModel.DataAnnotations;

    public class EmailEntity
    {
        [Key]
        public int Id { get; set; }

        public string MailAddress { get; set; }

        public ContactEntity ContactEntity { get; set; }
    }
}
