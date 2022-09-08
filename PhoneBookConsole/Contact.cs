using System;
using System.Collections.Generic;

namespace PhoneBookConsole
{
    public class Contact
    {
        public Contact(string name, string number)
        {
            this.Name = name;
            this.Number = number;
        }

        public string Name { get; set; }
        public string Number { get; set; }
    }
}
