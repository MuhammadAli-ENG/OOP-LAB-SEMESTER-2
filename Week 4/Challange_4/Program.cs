using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Challange_4;

namespace Challange_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Bookstore store = new Bookstore();
            while (true)
            {
                Console.WriteLine("\n==============================");
                Console.WriteLine("        BOOKSTORE MENU         ");
                Console.WriteLine("==============================");
                Console.WriteLine("1. Add a Book");
                Console.WriteLine("2. Add a Member");
                Console.WriteLine("3. Purchase a Book");
                Console.WriteLine("4. Exit");
                Console.WriteLine("==============================");
                Console.Write("Enter your choice: ");

                int choice;
                if (!int.TryParse(Console.ReadLine(), out choice))
                {
                    Console.WriteLine("Invalid input. Please enter a number between 1 and 4.");
                    continue;
                }

                switch (choice)
                {
                    case 1:
                        Console.Write("Enter book title: ");
                        string title = Console.ReadLine();
                        Console.Write("Enter author(s) (comma-separated): ");
                        List<string> authors = new List<string>(Console.ReadLine().Split(','));
                        Console.Write("Enter publisher: ");
                        string publisher = Console.ReadLine();
                        Console.Write("Enter ISBN: ");
                        string isbn = Console.ReadLine();
                        Console.Write("Enter price: ");
                        double price = double.Parse(Console.ReadLine());
                        Console.Write("Enter stock: ");
                        int stock = int.Parse(Console.ReadLine());
                        Console.Write("Enter year of publication: ");
                        int year = int.Parse(Console.ReadLine());
                        store.AddBook(new Book(title, authors, publisher, isbn, price, stock, year));
                        break;
                    case 2:
                        Console.Write("Enter member name: ");
                        string name = Console.ReadLine();
                        Console.Write("Enter member ID (0 for non-member): ");
                        int memberId = int.Parse(Console.ReadLine());
                        Console.Write("Enter initial bank balance: ");
                        double balance = double.Parse(Console.ReadLine());
                        store.AddMember(new Member(name, memberId, balance));
                        break;
                    case 3:
                        Console.Write("Enter member ID (0 for non-member): ");
                        int buyerId = int.Parse(Console.ReadLine());
                        Console.Write("Enter book title: ");
                        string bookTitle = Console.ReadLine();
                        Console.Write("Enter quantity: ");
                        int quantity = int.Parse(Console.ReadLine());
                        store.PurchaseBook(buyerId, bookTitle, quantity);
                        break;
                    case 4:
                        Console.WriteLine("Exiting program. Thank you for using the Bookstore System!");
                        return;
                    default:
                        Console.WriteLine("Invalid choice. Please select an option between 1 and 4.");
                        break;
                }
            }
        }
    }
}
