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



            List<Item> items = new List<Item>()
            {
                new Item{ Price=1.2M, Name="Cup", Quantity=59 },
                new Item{ Price=8.99M, Name="Book", Quantity=25 },
                new Item{ Price=3.2M, Name="Candy", Quantity=460 }
            };

            foreach (var g in items)
            {
                Console.WriteLine(g.Name);
            }
            

            var shop = new Shop();

            while (command != "Exit")
            {
                Console.WriteLine("Enter command");

                try
                {
                    var EnteredText = Console.ReadLine();

                    string[] ArrayOfEnteredText = EnteredText.Split(" ");

                    switch (ArrayOfEnteredText[0].ToLower())
                    {
                        case "add":
                            shop.LoadItems(ArrayOfEnteredText[1], Int32.Parse(ArrayOfEnteredText[2]));
                            Console.WriteLine("Case 1");
                            break;
                        case "buy":
                            Console.WriteLine("Case 2");
                            break;
                        case "list":
                            Console.WriteLine("Case 2");
                            break;
                        default:
                            throw new InvalidOperationException();
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Something went wrong {ex.Message}");
                }
            }



            //var shop = new Shop();

            //shop.ListItems();

            //shop.Buy("ItemName", 50);

            //shop.LoadItems("ItemName", 50);

            //var cup = new cup()
            //{
            //    name = "raudonas",
            //    price = 12
            //};

            //var candy = new candy()
            //{
            //    name = "kregzdute",
            //    price = 2
            //};

            //var book = new book()
            //{
            //    name = "vinetu",
            //    price = 8,
            //    author = "karlas majus"
            //};

            //var sum = calculationlibrary.sumnumbers(2, 5);

            //console.writeline(book.todescriptionstring());
        }
    }
}
