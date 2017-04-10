using ContactManager.Models;

namespace ContactManager.Models
{
    using System.Collections.Generic;
    using System.Linq;
    
    public class SampleContactRepository : IContactRepository
    {
        private int nextContactID;

        private IList<Contact> contacts; 

        public SampleContactRepository()
        {
            contacts = new List<Contact>(SampleData.Contacts);
            nextContactID = contacts.Count + 1;
        }

        public void Update(Contact updatedContact)
        {
            var contact = this.Get(updatedContact.ContactId);
            contact.FirstName = updatedContact.FirstName;
            contact.LastName = updatedContact.LastName;
            contact.Email = updatedContact.Email;
            contact.PhoneNumber = updatedContact.PhoneNumber;
            contact.Status = updatedContact.Status;
        }

        public Contact Get(int id)
        {
            return contacts.SingleOrDefault(c => c.ContactId == id);
        }

        public IQueryable<Contact> GetAll()
        {
            return contacts.AsQueryable();
        }

        public void Post(Contact contact)
        {
            contact.ContactId = nextContactID++;
            contacts.Add(contact);
        }

        public Contact Delete(int id)
        {
            var contact = this.Get(id);
            contacts.Remove(contact);
            return contact;
        }
    }
}