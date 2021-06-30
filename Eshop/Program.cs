using Eshop.Interfaces;
using Eshop.Logers;
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
            AiLogger logger = new ConsoleLogger();

            var command = "";
            
            var shop = new Shop(logger);

            shop.WellcomeToShopMessage();

            // bandyti visa while perkelti i shopa arba i kita klase

            while (command != "Exit")
            {
                try
                {
                    var EnteredText = InputLibrary.UserInputString();

                    string[] ArrayOfEnteredText = EnteredText.Split(" ");

                    

                    switch (ArrayOfEnteredText[0].ToLower())
                    {
                        case "add":
                            Console.Write(Message.enterName);
                            string name = InputLibrary.UserInputString().ToLower();
                            Console.Write(Message.enterPrice);
                            decimal price = InputLibrary.UserInputToDecimal();
                            Console.Write(Message.enterQuantity);
                            int quantity = InputLibrary.UserInputToInt(); 
                            shop.LoadItems(name, price, quantity);
                            break;
                        case "buy":
                            Console.Write(Message.buyItemName);
                            string itemName = Console.ReadLine().ToLower();
                            Console.Write(Message.buyItemQuantity);
                            int buyQuantity = InputLibrary.UserInputToInt();
                            shop.Buy(itemName, buyQuantity);
                            break;
                        case "list":
                            shop.ListItems();
                            break;
                        case "exit":
                            command = "Exit";
                            break;
                        default:
                            throw new InvalidOperationException();
                    }
                }

                catch (InvalidOperationException)
                {
                    Console.WriteLine("invalid command");
                    Console.WriteLine(Message.enterCommand);
                }

                //catch (Exception ex)
                //{
                //    Console.WriteLine($"Something went wrong {ex.Message}");
                //}
            }
        }
    }
}
