using Eshop.Models;
using Eshop.Models.Base;
using System;
using System.Collections.Generic;

namespace Eshop
{
    internal class Shop
    {
        public List<Item> Items = new List<Item>();

        public void ListItems()
        {
            foreach (var item in Items)
            {
                Console.WriteLine("/////////////////////////////");
                Console.WriteLine("   Item name: " + item.Name.ToUpper() + "\n"+ "   Item price: " + item.Price + "\n" + "   Item quantity: " + item.Quantity);
                Console.WriteLine("/////////////////////////////");
            }
        }

        public void Buy(string itemName, int quantity)
        {
            // to buy items
            foreach (var item in Items)
            {
                if (item.Name == itemName)
                {
                    item.Quantity = item.Quantity - quantity;
                }
                //Console.WriteLine(item.Quantity);
            }
        }

        public void LoadItems(string v1, decimal v2, int v3)
        {
            Items.Add(new Item { Name = v1, Quantity = v3, Price = v2 });

            //foreach (var item in Items)
            //{
            //    Console.WriteLine(item.Name);
            //}
        }
    }
}