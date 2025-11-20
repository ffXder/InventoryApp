using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inventory
{
    public class CurrencyFormatException : Exception
    {
        public CurrencyFormatException(string message) : base(message)
        {
            Console.WriteLine("This is CurrencyFormatException"); //tryy lang poo
        }
    }
}
