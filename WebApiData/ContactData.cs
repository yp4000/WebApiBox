using System;
using System.Collections.Generic;
using WebApiEntities;
using System.Linq;

namespace WebApiData
{
    public class ContactData
    {
        private List<ContactDTO> ContactList;
        private string[] NameList;
        private static ContactData contactData;

        /// <summary>
        /// Inicializa un objeto de la clase ContactData
        /// </summary>
        private ContactData()
        {
            var itemList = new List<ContactDTO>();
            var random = new Random();
            NameList = new string[] { "Jorge", "Ana", "Pedro", "Karla", "Santiago", "Mariana" };
            for (int x = 0; x <= NameList.Length - 1; x++)
            {
                var numero = random.Next(NameList.Length - 1);
                var item = new ContactDTO();
                item.ConctactId = x;
                item.Name = NameList[numero];
                item.Age = (10 * (numero + 1));
                item.Nickname = item.Name + " - " + numero.ToString();
                item.Active = (numero % 2 == 0) ? true : false;

                itemList.Add(item);
            }

            ContactList = itemList;
        }

        public static ContactData getInstance()
        {
            if (Equals(null, contactData))
            {
                contactData = new ContactData();
            }
            return contactData;
        }

        public ContactDTO Add(ContactDTO contact)
        {
            ContactList.Add(contact);
            return ContactList.FirstOrDefault(x => x.ConctactId == contact.ConctactId);
        }

        public List<ContactDTO> GetAll()
        {
            return ContactList;
        }

        public ContactDTO Get(int contactId)
        {
            return ContactList.FirstOrDefault( x => x.ConctactId == contactId);
        }

        public void Remove(int contactId)
        {
            ContactList.RemoveAll(x => x.ConctactId == contactId);
        }

        public bool Update(ContactDTO contact)
        {
            bool response = ContactList.Exists(x => x.ConctactId == contact.ConctactId);
            if (response)
            {
                foreach (var item in ContactList)
                {
                    if(item.ConctactId == contact.ConctactId)
                    {
                        item.Active = contact.Active;
                        item.Age = contact.Age;
                        item.Name = contact.Name;
                        item.Nickname = contact.Nickname;

                        ContactList[contact.ConctactId] = item;
                        break;
                    }
                }
            }
            return response;
        }

    }
}
