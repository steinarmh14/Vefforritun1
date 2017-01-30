using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Project4.Utilities
{
    public class MyApplicationException : Exception
    {
        public MyApplicationException(string message) : base(message)
        {

        }
    }
}