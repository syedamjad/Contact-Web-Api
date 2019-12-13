namespace ContactWebApi.Models
{
    public class Email
    {
        public int Id { get; set; }

        public string MailAddress { get; set; }

        public Contact Contact { get; set; }
    }
}
