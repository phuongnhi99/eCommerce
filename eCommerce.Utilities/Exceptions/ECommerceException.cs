using System;
using System.Collections.Generic;
using System.Text;

namespace eCommerce.Utilities.Exceptions
{
    public class ECommerceException : Exception
    {
        public ECommerceException()
        {
        }

        public ECommerceException(string message)
            : base(message)
        {
        }

        public ECommerceException(string message, Exception inner)
            : base(message, inner)
        {
        }
    }
}
