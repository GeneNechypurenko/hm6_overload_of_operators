using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hm6_overload_of_operators
{
    public class NameIsEmptyException : Exception
    {
        public NameIsEmptyException(string message) : base(message) { }
    }
}
