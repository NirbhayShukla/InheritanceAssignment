using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssignmentInheritance
{
    internal class Book
    {
        private string name, title, author;
        private int isbn, price, quantity;

        public string NAME
        {
            get { return name; }
            set { name = value; }
        }

        public int ISBN
        {
            get { return isbn; }
            set { isbn = value; }
        }

        public string TITLE
        {
            get {  return title; }
            set { title = value; }
        }

        public string AUTHOR
        {
            get { return author; }
            set
            {
                author = value;
            }
        }

        public int PRICE
        {
            set { price = value; }
            get { return price; }
        }

        public int QUANTITY
        {
            set { quantity = value; }
            get { return quantity; }
        }

        int calculate()
        {
            return price * quantity;
        }

        public void show()
        {
            Console.WriteLine($"Name = {name} , Title = {title} , Author = {author} , ISBN = {isbn}");
            Console.WriteLine($"Quantity = {quantity} , Price = {price}");
            Console.WriteLine("Total Bill = "+calculate());
        }

        static void Main(string[] args)
        {
            Book book = new Book();
            Console.WriteLine("Enter Name");
            book.NAME = Console.ReadLine();
            Console.WriteLine("Enter Title");
            book.TITLE = Console.ReadLine();
            Console.WriteLine("Enter Author");
            book.AUTHOR = Console.ReadLine();
            Console.WriteLine("Enter ISBN");
            book.ISBN = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter price");
            book.PRICE = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter Quantity");
            book.QUANTITY = int.Parse(Console.ReadLine());
            book.show();
        }
    }
}
