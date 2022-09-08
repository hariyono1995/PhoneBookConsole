using System;
using System.Collections.Generic;
using System.Linq;

namespace PhoneBookConsole
{

    internal class PhoneBook
    {
        private List<Contact> _contact { get; set; } = new List<Contact>();

        private void ContactValidation(Contact contact, string searchTerm)
        {
            if (contact == null)
                Console.WriteLine($"{searchTerm} not found.");
            else
                Console.WriteLine($"Contact : \nName : {contact.Name}\nNumber : {contact.Number}");
        }
        private void DisplayContact()
        {
            foreach (var contact in _contact)
                Console.WriteLine($"Name : {contact.Name}\nNumber : {contact.Number}");
        }

        public void GetAllContacts()
        {
            if (_contact.Count == 0) Console.WriteLine(_contact.Count);
            DisplayContact();
        }

        public void AddContact(Contact contact) => _contact.Add(contact);
        public void DisplayContactByNumber(string number) => ContactValidation(_contact.FirstOrDefault(c => c.Number.Contains(number)), number);
        public void DisplayContactByName(string name) => ContactValidation(_contact.FirstOrDefault(c => c.Name.Contains(name)), name);

    }
}
