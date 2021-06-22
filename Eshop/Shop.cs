using System;

namespace Eshop
{
    internal class Shop
    {
        public readonly string _name;

        public Shop( string name)
        {
            _name = name;
        }

        public Shop() : this("Default")
        {

        }

        public string GetInfo()
        {
            return "glkadjga;dfgadofgaodi";
        }

        public void ListItems()
        {
            throw new NotImplementedException();
        }
        
        public void Buy(string itemName, int quantity)
        {
            // to load items
        }

        public void LoadItems(string v1, int v2)
        {
            throw new NotImplementedException();
        }
    }
}