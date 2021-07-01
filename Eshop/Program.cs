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
            
            var shop = new Shop(logger);

            shop.WellcomeToShopMessage();

            var view = new ConsoleView(logger);

            view.View(shop);

        }
    }
}
