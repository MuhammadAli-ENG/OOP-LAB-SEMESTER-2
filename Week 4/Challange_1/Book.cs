using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challange_1
{
    public class Book
    {
        private string title;
        private string[] authors;
        private string publisher;
        private string isbn;
        private double price;
        private int stock;
        private int authorCount;

        public Book(string title, string[] authors, string publisher, string isbn, double price, int stock)
        {
            this.title = title;
            this.authors = new string[4];
            this.authorCount = 0;
            foreach (string author in authors)
            {
                if (authorCount < 4)
                {
                    this.authors[authorCount++] = author;
                }
            }
            this.publisher = publisher;
            this.isbn = isbn;
            this.price = price;
            this.stock = stock;
        }
        public Book()
        {
            this.title = "";
            this.authors = new string[4];
            this.authorCount = 0;
            this.publisher = "";
            this.isbn = "";
            this.price = 0.0;
            this.stock = 0;
        }

        public void SetTitle(string title)
        {
            this.title = title;
        }

        public string GetTitle()
        {
            return this.title;
        }

        public bool IsTitleMatch(string title)
        {
            return this.title.Equals(title, StringComparison.OrdinalIgnoreCase);
        }

        public void AddAuthor(string author)
        {
            if (authorCount < 4)
            {
                this.authors[authorCount++] = author;
            }
            else
            {
                Console.WriteLine("Cannot add more than 4 authors.");
            }
        }

        public string[] GetAuthors()
        {
            return this.authors;
        }

        public int GetAuthorCount()
        {
            return this.authorCount;
        }
        public void SetPublisher(string publisher)
        {
            this.publisher = publisher;
        }

        public string GetPublisher()
        {
            return this.publisher;
        }

        public void SetISBN(string isbn)
        {
            this.isbn = isbn;
        }

        public string GetISBN()
        {
            return this.isbn;
        }

        public bool IsISBNMatch(string isbn)
        {
            return this.isbn.Equals(isbn, StringComparison.OrdinalIgnoreCase);
        }

        public void SetPrice(double price)
        {
            this.price = price;
        }

        public double GetPrice()
        {
            return this.price;
        }

        public void SetStock(int stock)
        {
            this.stock = stock;
        }

        public int GetStock()
        {
            return this.stock;
        }

        public void UpdateStock(int quantity)
        {
            this.stock += quantity;
        }


        public void DisplayDetails()
        {
            Console.WriteLine("Title: " + title);
            Console.WriteLine("Authors: " + string.Join(", ", authors, 0, authorCount));
            Console.WriteLine("Publisher: " + publisher);
            Console.WriteLine("ISBN: " + isbn);
            Console.WriteLine("Price: $" + price);
            Console.WriteLine("Stock: " + stock);
        }
    }
}
