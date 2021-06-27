using Eshop.Models;
using Eshop.Models.Base;
using System;
using System.Collections.Generic;

namespace Eshop
{
    internal class Shop
    {
        public List<Item> Items = new List<Item>();

        public void WellcomeToShopMessage()
        {
            Console.WriteLine(Message.decoration);
            Console.WriteLine(Message.wellcome);
            Console.WriteLine(Message.enterCommand);
            Console.WriteLine(Message.decoration);
        }

        public void ListItems()
        {
            foreach (var item in Items)
            {
                Console.WriteLine(Message.decoration);
                Console.WriteLine("   Item name: " + item.Name.ToUpper() + "\n" + 
                                  "   Item price: " + item.Price + "\n" + 
                                  "   Item quantity: " + item.Quantity);
                Console.WriteLine(Message.decoration);
            }
            Console.WriteLine(Message.enterCommand);
        }

        public void Buy(string itemName, int quantity)
        {
            foreach (var item in Items)
            {
                if (item.Name == itemName)
                {
                    item.Quantity = CalculationLibrary.Difnumbers(item.Quantity, quantity);
                }
            }
            Console.WriteLine(Message.enterCommand);
        }

        public void LoadItems(string v1, decimal v2, int v3)
        {
            Items.Add(new Item { Name = v1, Quantity = v3, Price = v2 });
            Console.WriteLine(Message.enterCommand);
        }
    }
}