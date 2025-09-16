using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inventory
{
    public class CustomException : Exception
    {
        public CustomException(string message) : base(message)
        {
            Console.WriteLine("This is custom Exception"); //tryy lang poo
        }
    }
}
