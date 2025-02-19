using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challange_4
{
    public class Bookstore
    {
        private List<Book> inventory = new List<Book>();
        private List<Member> members = new List<Member>();
        private double totalSales = 0;
        private int membershipCount = 0;

        public void AddBook(Book book)
        {
            inventory.Add(book);
        }

        public void AddMember(Member member)
        {
            members.Add(member);
            if (member.MemberID != 0)
            {
                membershipCount++;
                totalSales += 10; // Membership fee
            }
        }

        public void PurchaseBook(int memberId, string title, int quantity)
        {
            Member member = null;
            foreach (var m in members)
            {
                if (m.MemberID == memberId)
                {
                    member = m;
                    break;
                }
            }

            Book book = null;
            foreach (var b in inventory)
            {
                if (b.Title.Equals(title, StringComparison.OrdinalIgnoreCase))
                {
                    book = b;
                    break;
                }
            }

            if (book != null && member != null)
            {
                double totalCost = book.Price * quantity;
                if (member.MemberID != 0)
                {
                    totalCost *= 0.95; // 5% discount for members
                }

                if (member.MoneyInBank >= totalCost && book.Stock >= quantity)
                {
                    member.MoneyInBank -= totalCost;
                    book.Stock -= quantity;
                    totalSales += totalCost;
                    Console.WriteLine($"{member.Name} purchased {quantity} copies of {book.Title} for ${totalCost}");
                }
                else
                {
                    Console.WriteLine("Insufficient funds or stock!");
                }
            }
            else
            {
                Console.WriteLine("Book or Member not found!");
            }
        }
    }
}
