
using System.Collections.Generic;
using WebApiEntities;

namespace WebApiBusiness.Repository
{
    public interface IContactRepository
    {
        IEnumerable<ContactDTO> GetAll();
        ContactDTO Get(int contactId);
        ContactDTO Add(ContactDTO contact);
        void Remove(int contactId);
        bool Update(ContactDTO contact);
    }
}
