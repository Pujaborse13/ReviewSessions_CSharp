using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReviewSession_3
{
   
    public class InsufficientFundsException : Exception
    {
        public InsufficientFundsException(string message) : base(message) { }
    }


    public class ProductOutOfStockException : Exception
    {
        public ProductOutOfStockException(string message) : base(message) { }
    }


    public class InvalidAgeException : Exception
    {
        public InvalidAgeException(string message) : base(message) { }
    }


}
