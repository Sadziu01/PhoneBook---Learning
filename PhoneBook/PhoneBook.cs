using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhoneBook
{
    public class PhoneBook
    {
        public List<Contact> Contacts { get; set; } = new List<Contact>();

        private void DisplayContactDetails(Contact contact)
        {
            Console.WriteLine($"Contact: {contact.Name}, {contact.Number}");
        }

        private void DisplayContactsDetails(List<Contact> contacts)
        {
            foreach (Contact contact in contacts)
            {
                DisplayContactDetails(contact);
            }
        }

        public void AddContact(Contact contact)
        {
            if(contact.Name != null || contact.Number != null)
            {
                Contacts.Add(contact);
            }
        }

        public void DisplayContactByNumber(string number)
        {
            var contact = Contacts.FirstOrDefault(c => c.Number == number);

            if(contact == null)
            {
                Console.WriteLine("Contact not found");
            }
            else
            {
                DisplayContactDetails(contact);

            }
        }

        public void DisplayAllContacts()
        {
            DisplayContactsDetails(Contacts);
        }

        public void DisplayMatchingContacts(string searchPharse)
        {
            var matchingContacts = Contacts.Where(c => c.Name.Contains(searchPharse)).ToList();

            DisplayContactsDetails(matchingContacts);
        }

        public void RemoveContact(string number)
        {
            var removeContact = Contacts.FirstOrDefault(c => c.Number == number);

            Contacts.Remove(removeContact);
        }
    }
}
