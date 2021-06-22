using System;

namespace Eshop
{
    class Program
    {
        static void Main(string[] args)
        {
            var shop = new Shop();

            shop.ListItems();

            shop.Buy("ItemName", 50);

            shop.LoadItems("ItemName", 50);

            Console.WriteLine(shop);
        }
    }
}
