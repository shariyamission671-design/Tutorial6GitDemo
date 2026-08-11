using System;
using System.Collections.Generic;

namespace Tutorial6GitHubDemo
{
    class Product
    {
        public string Name { get; set; }
        public double Price { get; set; }

        public Product(string name, double price)
        {
            Name = name;
            Price = price;
        }
    }

    class Customer
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public List<Product> ShoppingList { get; set; }

        public Customer(int id, string name, string email)
        {
            Id = id;
            Name = name;
            Email = email;
            ShoppingList = new List<Product>();
        }

        public void DisplayCustomerInfo()
        {
            Console.WriteLine("Customer Information:");
            Console.WriteLine("ID: " + Id);
            Console.WriteLine("Name: " + Name);
            Console.WriteLine("Email: " + Email);
            Console.WriteLine("Shopping List:");
            foreach (Product item in ShoppingList)
            {
                Console.WriteLine(" - " + item.Name + " ($" + item.Price + ")");
            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Customer Cust1 = new Customer(1, "John Doe", "john.doe@example.com");

            Product p1 = new Product("Keyboard", 25.99);
            Product p2 = new Product("Mouse", 15.50);
            Product p3 = new Product("Monitor", 199.99);

            Cust1.ShoppingList.Add(p1);
            Cust1.ShoppingList.Add(p2);
            Cust1.ShoppingList.Add(p3);

            Cust1.DisplayCustomerInfo();
        }
    }
}

