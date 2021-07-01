using Eshop.Interfaces;
using System;

namespace Eshop
{
    internal class ConsoleView
    {
        private Shop shop;

        private AiLogger _logger;

        public ConsoleView(AiLogger logger)
        {
            _logger = logger;
        }

        public void View(Shop shop)
        {
            this.shop = shop;

            var command = "";

            while (command != "Exit")
            {
                try
                {
                    var EnteredText = InputLibrary.UserInputString();

                    string[] ArrayOfEnteredText = EnteredText.Split(" ");

                     switch (ArrayOfEnteredText[0].ToLower())
                    {
                        case "add":
                            _logger.Write(Message.enterName);
                            string name = InputLibrary.UserInputString().ToLower();
                            _logger.Write(Message.enterPrice);
                            decimal price = InputLibrary.UserInputToDecimal();
                            _logger.Write(Message.enterQuantity);
                            int quantity = InputLibrary.UserInputToInt(); 
                            shop.LoadItems(name, price, quantity);
                            break;
                        case "buy":
                            _logger.Write(Message.buyItemName);
                            string itemName = Console.ReadLine().ToLower();
                            _logger.Write(Message.buyItemQuantity);
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
                    _logger.Write("invalid command");
                    _logger.Write(Message.enterCommand);
                }

            }
        }
    }
}