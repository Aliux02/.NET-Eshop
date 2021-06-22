using Eshop.Models;
using System;

namespace Eshop
{
    class Program
    {
        static void Main(string[] args)
        {
            var command = "";

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
