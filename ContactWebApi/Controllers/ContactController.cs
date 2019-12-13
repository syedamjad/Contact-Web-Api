namespace ContactWebApi.Controllers
{
    using Models;
    using Repository;
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
