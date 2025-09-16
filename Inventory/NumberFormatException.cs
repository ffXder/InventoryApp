using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inventory
{
    public class NumberFormatException : Exception
    {
        public NumberFormatException(string message) : base(message)
        {
            Console.WriteLine("This is custom Exception"); //tryy lang poo
        }
    }
}
