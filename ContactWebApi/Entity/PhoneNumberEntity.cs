namespace ContactWebApi.Entity
{
    using System.ComponentModel.DataAnnotations;

    public class PhoneNumberEntity
    {
        [Key]
        public int Id { get; set; }

        public string Number { get; set; }

        public ContactEntity ContactEntity { get; set; }
    }
}
