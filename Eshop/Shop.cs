using Eshop.Models;
using Eshop.Models.Base;
using System;
using System.Collections.Generic;

namespace Eshop
{
    internal class Shop
    {
        //public readonly string _name;

        //public Shop( string name)
        //{
        //    _name = name;
        //}

        //public Shop() : this("Default")
        //{

        //}

        //public string GetInfo()
        //{
        //    return "glkadjga;dfgadofgaodi";
        //}



        public void ListItems()
        {
            // list items
        }

        public void Buy(string itemName, int quantity)
        {
            // to buy items
        }

        public void LoadItems(string v1, int v2)
        {
            //to load items
            //if (v1 == Item.Name)
            //{

            //}
            List<Item> items = new List<Item>()
            {
                new Item{ Price=1.2M, Name="Cup", Quantity=59 },
                new Item{ Price=8.99M, Name="Book", Quantity=25 },
                new Item{ Price=3.2M, Name="Candy", Quantity=460 }
            };

            foreach (var item in items)
            {
                if (v1 == item.Name)
                {
                    // then pridedam cenu
                }
            }
        }
    }
}