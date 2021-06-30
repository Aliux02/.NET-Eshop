using Eshop.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eshop.Logers
{
    public class ConsoleLogger : AiLogger
    {
        public void Write(string input)
        {
            Console.WriteLine(input);
        }
    }
}
