using System.Collections.Generic;
using WebApiBusiness.Repository;
using WebApiEntities;
using WebApiData;

namespace WebApiBusiness.Logic
{
    public class ContactRepository : IContactRepository
    {
        private ContactData data;
        public ContactRepository()
        {
            data = ContactData.getInstance();
        }

        public ContactDTO Add(ContactDTO contact)
        {
            return data.Add(contact);
        }

        public ContactDTO Get(int contactId)
        {
            return data.Get(contactId);
        }

        public IEnumerable<ContactDTO> GetAll()
        {
            return data.GetAll();
        }

        public void Remove(int contactId)
        {
            data.Remove(contactId);
        }

        public bool Update(ContactDTO contact)
        {
            return data.Update(contact);
        }
    }
}
