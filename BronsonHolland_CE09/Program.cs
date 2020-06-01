using System;
using System.Collections.Generic;
using System.Linq;
namespace BronsonHolland_CE09
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, Customer> customers = new Dictionary<string, Customer>();
            customers.Add("n1", new Customer("1", "n1"));
            customers.Add("n2", new Customer("2", "n2"));
            customers.Add("n3", new Customer("3", "n3"));
            customers.Add("n4", new Customer("4", "n4"));
            customers.Add("n5", new Customer("5", "n5"));
            Customer currentCustomer = null;
            List<Item> inventory = new List<Item>();
            List<Cart> carts = new List<Cart>();
            while (true)
            {
                Console.Write("1. Select current shopper\n"
                    + "2. View store inventory\n"
                    + "3. View cart\n"
                    + "4. Add item to cart\n"
                    + "5. Remove item from cart\n"
                    + "6. Remove item from cart\n"
                    + "7. Exit\n"
                    + "Please choose a menu option: ");
                string input = Console.ReadLine().ToLower();

                switch (input)
                {
                    case "1":
                    case "select current shopper":
                        {
                            SelectCurrentCustomer(customers, currentCustomer);
                            Console.WriteLine("Press any key to continue.");
                            Console.ReadLine();
                            Console.Clear();

                        }

                        break;
                    case "2":
                    case "view store inventory":
                        {
                            Console.WriteLine("Press any key to continue.");
                            Console.ReadLine();
                            Console.Clear();
                        }
                        break;
                    case "3":
                    case "view cart":
                        {
                            Console.WriteLine("Press any key to continue.");
                            Console.ReadLine();
                            Console.Clear();
                        }
                        break;
                    case "4":
                    case "add item to cart":
                        {
                            Console.WriteLine("Press any key to continue.");
                            Console.ReadLine();
                            Console.Clear();
                        }
                        break;
                    case "5":
                    case "remove item from cart":
                        {

                        }
                        break;
                    case "6":
                    case "complete purchase":
                        {
                            
                        }
                        break;
                    case "7":
                    case "exit":
                        {
                            return;
                        }
                }
            }
        }

        private static void CreateNewCustomer(Dictionary<string, Customer> customers)
        {
            Console.WriteLine("What is the customers name: ");
            string name = Console.ReadLine();
            if (customers.ContainsKey(name))
            {
                Console.WriteLine("Customer alredy exists.");
            }
            else
            {
                customers.Add(name, new Customer(name));
            }
        }

        private static void SelectCurrentCustomer(Dictionary<string, Customer> customers, Customer currentCustomer)
        {
            List<KeyValuePair<string, Customer>> customersKvp = customers.ToList();
            List<Customer> unsortedCustomers = new List<Customer>();

            foreach (KeyValuePair<string, Customer> customerKvp in customersKvp)
            {
                unsortedCustomers.Add(customerKvp.Value);
            }

            List<Customer> sortedCustomers = new List<Customer>();
            sortedCustomers = unsortedCustomers.OrderBy(x => x.Id).ToList();

            foreach (Customer customer in sortedCustomers)
            {
                Console.WriteLine($"{customer.Id}. {customer.Name}");
            }
           
            Console.WriteLine("Please choose a customer or type add to create a customer: ");
            string input = Console.ReadLine().ToLower();
            if (input == "add")
            {
                CreateNewCustomer(customers);
            }
            else
            {
                Customer selectedCustomer;
                Console.WriteLine("type something");
                string selectedInput = Console.ReadLine();
                selectedCustomer = sortedCustomers.SingleOrDefault(x => x.Id == selectedInput);

                if (selectedCustomer == null)
                {
                    Console.WriteLine("Invalid customer.");
                    return;
                }
                currentCustomer = selectedCustomer;
            }
        }
    }
}
