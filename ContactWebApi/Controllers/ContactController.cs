namespace ContactWebApi.Controllers
{
    using ContactWebApi.Models;
    using ContactWebApi.Repository;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.Extensions.Logging;

    [ApiController]
    public class ContactController : ControllerBase
    {
        private readonly ILogger<ContactController> logger;
        private readonly IContactRepository contactRepository;

        public ContactController(ILogger<ContactController> logger,
            IContactRepository contactRepository)
        {
            this.logger = logger;
            this.contactRepository = contactRepository;
        }

        [HttpGet]
        [Route("api/GetContacts")]
        public IActionResult GetContacts()
        {
            //var rng = new Random();
            //return Enumerable.Range(1, 5).Select(index => new Contact
            //{
            //    DateOfBirth = DateTime.Now.AddDays(index),
            //    FirstName = "amjad",
            //    LastName = "amjad",
            //    Emails = new List<string> {"sdf","sdf","sdf" },
            //    PhoneNumbers = new List<string> { "er", "sdf", "sdf"}
            //})
            //.ToArray();
            var contacts = this.contactRepository.GetContacts();
            return Ok(contacts);
        }

        [HttpPost]
        [Route("api/SaveContact")]
        public IActionResult SaveContact([FromBody] Contact contact)
        {
            this.contactRepository.Save(contact);
            return Ok(true);
        }
    }
}
