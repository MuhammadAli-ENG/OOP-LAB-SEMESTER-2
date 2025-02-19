using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challange_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Book[] books = new Book[100];
            int bookCount = 0;

            while (true)
            {
                Console.WriteLine("==== Menu: ====");
                Console.WriteLine("1. Add a Book");
                Console.WriteLine("2. Search by Title");
                Console.WriteLine("3. Search by ISBN");
                Console.WriteLine("4. Update Stock");
                Console.WriteLine("5. Display All Books");
                Console.WriteLine("6. Exit");
                Console.Write("Enter your choice: ");
                string choice = Console.ReadLine();



                switch (choice)
                {
                    case "1":
                        if (bookCount < 100)
                        {
                            Console.Write("Enter Title: ");
                            string title = Console.ReadLine();

                            Console.Write("Enter Number of Authors (up to 4): ");
                            int numAuthors = int.Parse(Console.ReadLine());
                            string[] authors = new string[numAuthors];
                            for (int i = 0; i < numAuthors; i++)
                            {
                                Console.Write($"Enter Author {i + 1}: ");
                                authors[i] = Console.ReadLine();
                            }

                            Console.Write("Enter Publisher: ");
                            string publisher = Console.ReadLine();

                            Console.Write("Enter ISBN: ");
                            string isbn = Console.ReadLine();

                            Console.Write("Enter Price: ");
                            double price = double.Parse(Console.ReadLine());

                            Console.Write("Enter Stock: ");
                            int stock = int.Parse(Console.ReadLine());

                            books[bookCount++] = new Book(title, authors, publisher, isbn, price, stock);
                            Console.WriteLine("Book added successfully!");
                        }
                        else
                        {
                            Console.WriteLine("Cannot add more books. Maximum limit reached.");
                        }
                        break;

                    case "2":
                        Console.Write("Enter Title to Search: ");
                        string searchTitle = Console.ReadLine();
                        bool foundByTitle = false;
                        for (int i = 0; i < bookCount; i++)
                        {
                            if (books[i].IsTitleMatch(searchTitle))
                            {
                                books[i].DisplayDetails();
                                foundByTitle = true;
                                break;
                            }
                        }
                        if (!foundByTitle)
                        {
                            Console.WriteLine("Book not found.");
                        }
                        break;

                    case "3":
                        Console.Write("Enter ISBN to Search: ");
                        string searchISBN = Console.ReadLine();
                        bool foundByISBN = false;
                        for (int i = 0; i < bookCount; i++)
                        {
                            if (books[i].IsISBNMatch(searchISBN))
                            {
                                books[i].DisplayDetails();
                                foundByISBN = true;
                                break;
                            }
                        }
                        if (!foundByISBN)
                        {
                            Console.WriteLine("Book not found.");
                        }
                        break;

                    case "4":
                        Console.Write("Enter ISBN of the Book: ");
                        string updateISBN = Console.ReadLine();
                        bool foundForUpdate = false;
                        for (int i = 0; i < bookCount; i++)
                        {
                            if (books[i].IsISBNMatch(updateISBN))
                            {
                                Console.Write("Enter Quantity to Add/Subtract: ");
                                int quantity = int.Parse(Console.ReadLine());
                                books[i].UpdateStock(quantity);
                                Console.WriteLine("Stock updated successfully!");
                                foundForUpdate = true;
                                break;
                            }
                        }
                        if (!foundForUpdate)
                        {
                            Console.WriteLine("Book not found.");
                        }
                        break;

                    case "5":
                        for (int i = 0; i < bookCount; i++)
                        {
                            Console.WriteLine($"\nBook {i + 1}:");
                            books[i].DisplayDetails();
                        }
                        break;

                    case "6":
                        Console.WriteLine("Exiting the program...");
                        return;

                    default:
                        Console.WriteLine("Invalid choice. Please try again.");
                        break;
                }
            }
        }
    }
}
