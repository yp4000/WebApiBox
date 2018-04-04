using System.Web.Http;
using WebApiBusiness.Repository;
using WebApiBusiness.Logic;
using WebApiEntities;
using System.Collections.Generic;

namespace WebApiBox.Controllers
{
    public class ContactController : ApiController
    {
        static readonly IContactRepository contactRepository = new ContactRepository();

        [HttpGet]
        public IEnumerable<ContactDTO> GetAll()
        {
            return contactRepository.GetAll();
        }

        [HttpGet]
        public ContactDTO GetById(string id)
        {
            return contactRepository.Get(int.Parse(id));
        }

        [HttpPost]
        public ContactDTO Add(ContactDTO item)
        {
            return contactRepository.Add(item);
        }

        [HttpDelete]
        public void Remove(int id)
        {
            contactRepository.Remove(id);
        }

        [HttpPut]
        public bool Update(ContactDTO item)
        {
            return contactRepository.Update(item);
        }

        public IHttpActionResult Authorize()
        {
            return Ok("Autorizado");
        }
    }
}
