using System;

namespace BronsonHolland_CE09
{
    class Program
    {
        static void Main(string[] args)
        {
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
    }
}
