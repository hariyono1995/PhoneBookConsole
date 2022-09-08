using System;

namespace PhoneBookConsole
{
    internal class Program
    {
        private static void TitleMenu(string title)
        {
            Console.WriteLine(title);
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Hello, Welcome to Phone Book Console Aplication.");
            Console.WriteLine("Press another key to start or 'q' to quit the program");

            ConsoleKeyInfo cki;
            PhoneBook pb = new PhoneBook();

            do
            {
                cki = Console.ReadKey(true);

                switch (cki.Key)
                {
                    case ConsoleKey.H:
                        Console.WriteLine("Press another key to start or 'q' to quit the program");
                        break;
                    case ConsoleKey.M:
                        Console.Clear();
                        TitleMenu("Please Select in Menu: ");
                        Console.WriteLine("1. Add Contact");
                        Console.WriteLine("2. Display contact by number");
                        Console.WriteLine("3. View all contacts");
                        Console.WriteLine("4. Search for contacts for a given name");
                        Console.WriteLine("5. Press 'H' to help");

                        break;
                    case ConsoleKey.D1:
                        Console.Clear();
                        TitleMenu("Enter your name: ");
                        string name = Console.ReadLine();
                        Console.WriteLine("Enter your number: ");
                        string number = Console.ReadLine();

                        pb.AddContact(new Contact(name, number));

                        Console.WriteLine("Adding contact successfully");
                        goto case ConsoleKey.H;
                        break;
                    case ConsoleKey.D2:
                        Console.Clear();
                        TitleMenu("Search Contact by number, Please, enter your keyword.");
                        string searchByNumber = Console.ReadLine();
                        pb.DisplayContactByNumber(searchByNumber);
                        goto case ConsoleKey.H;
                        break;
                    case ConsoleKey.D3:
                        Console.Clear();
                        pb.GetAllContacts();
                        goto case ConsoleKey.H;
                        break;
                    case ConsoleKey.D4:
                        Console.Clear();
                        TitleMenu("Search Contact by number, Please, enter your keyword.");
                        string searchByName = Console.ReadLine();
                        pb.DisplayContactByName(searchByName);
                        goto case ConsoleKey.H;
                        break;
                    default:
                        goto case ConsoleKey.M;
                        break;
                }
            } while (cki.Key != ConsoleKey.Q);
        }


    }
}
