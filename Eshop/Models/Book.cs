using Eshop.Models.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eshop.Models
{
    public class Book :Item
    {
        public string Author { get; set; }

        public new string ToDescriptionString()
        {
            return $"{Name} writen by {Author} and prce: {Price}";
        }
    }
}
