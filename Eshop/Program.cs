using Eshop.Models;
using Eshop.Models.Base;
using System;
using System.Collections.Generic;

namespace Eshop
{
    class Program
    {
        static void Main(string[] args)
        {
            var command = "";
            
            var shop = new Shop();

            while (command != "Exit")
            {
                Console.WriteLine("////////////////////");
                Console.WriteLine("Welcome To SHOP");
                Console.WriteLine("Enter command 'add', 'buy', 'list'");
                Console.WriteLine("////////////////////");

                try
                {
                    var EnteredText = Console.ReadLine();

                    string[] ArrayOfEnteredText = EnteredText.Split(" ");

                    switch (ArrayOfEnteredText[0].ToLower())
                    {
                        case "add":
                            Console.Write("Enter item name: ");
                            string Name = Console.ReadLine().ToLower();
                            Console.Write("Enter item price: ");
                            decimal Price = Convert.ToDecimal(Console.ReadLine());
                            Console.Write("Enter item quantity: ");
                            int Quantity = Convert.ToInt32(Console.ReadLine());
                            shop.LoadItems(Name, Price, Quantity);
                            break;
                        case "buy":
                            Console.Write("Enter item name you want to buy: ");
                            string itemName = Console.ReadLine().ToLower();
                            Console.Write("Enter item quantity you want to buy: ");
                            int quantity = Convert.ToInt32(Console.ReadLine());
                            shop.Buy(itemName, quantity);
                            break;
                        case "list":
                            shop.ListItems();
                            break;
                        default:
                            throw new InvalidOperationException();
                    }
                }

                //catch (InvalidOperationException)
                //{
                //    Console.WriteLine("Invalid command");
                //}

                catch (Exception ex)
                {
                    Console.WriteLine($"Something went wrong {ex.Message}");
                }
            }



            //var shop = new Shop();

            //shop.ListItems();

            //shop.Buy("ItemName", 50);

            //shop.LoadItems("ItemName", 50);


        }
    }
}
