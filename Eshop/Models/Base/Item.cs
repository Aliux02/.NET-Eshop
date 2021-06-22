using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eshop.Models.Base
{
    //abtract klase skirta ne obj kurimui, o perpanaudojimui
    public abstract class Item
    {
        public string Name { get; set; }

        public decimal Price { get; set; }

        public int Quantity { get; set; }

        public string ToDescriptionString()
        {
            return $"{Name} and prce: {Price}";
        }
    }
}
