using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionHandling_Task1
{
    internal class DuplicateNumberException : Exception
    {
        public DuplicateNumberException(string message) : base(message) { }

    }
}
