using Eshop.Models;
using Eshop.Models.Base;
using System;
using System.Collections.Generic;

namespace Eshop
{
    internal class Shop
    {
        public List<Item> Items = new List<Item>();

        //public readonly string _name;

        //public Shop( string name)
        //{
        //    _name = name;
        //}

        //public Shop() : this("Default")
        //{

        //}

        public void ListItems()
        {
            foreach (var item in Items)
            {
                Console.WriteLine(item.Name);
            }
        }

        public void Buy(string itemName, int quantity)
        {
            // to buy items
        }

        public void LoadItems(string v1, decimal v2, int v3)
        {

            
            //{
            //    new Item { Price = v2, Name = v1, Quantity = v3 },
            //};
            Items.Add(new Item { Name = v1, Quantity = v3, Price = v2 });

            foreach (var item in Items)
            {
                Console.WriteLine(item.Name);
            }
        }
    }
}