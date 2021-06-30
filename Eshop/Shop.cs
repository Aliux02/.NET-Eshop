using Eshop.Interfaces;
using Eshop.Models;
using Eshop.Models.Base;
using System;
using System.Collections.Generic;

namespace Eshop
{
    internal class Shop
    {
        private AiLogger _logger;

        public Shop(AiLogger logger)
        {
            _logger = logger;
        }

        public List<Item> Items = new List<Item>();

        public void WellcomeToShopMessage()
        {
            _logger.Write(Message.decoration);
            _logger.Write(Message.wellcome);
            _logger.Write(Message.enterCommand);
            _logger.Write(Message.decoration);
        }

        public void ListItems()
        {
            foreach (var item in Items)
            {
                _logger.Write(Message.decoration);
                _logger.Write("   Item name: " + item.Name.ToUpper() + "\n" + 
                                  "   Item price: " + item.Price + "\n" + 
                                  "   Item quantity: " + item.Quantity);
                _logger.Write(Message.decoration);
            }
            _logger.Write(Message.enterCommand);
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
            _logger.Write(Message.enterCommand);
        }

        public void LoadItems(string v1, decimal v2, int v3)
        {
            Items.Add(new Item { Name = v1, Quantity = v3, Price = v2 });
            _logger.Write(Message.enterCommand);
        }
    }
}