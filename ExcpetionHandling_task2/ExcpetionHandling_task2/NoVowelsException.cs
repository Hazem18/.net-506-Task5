using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExcpetionHandling_task2
{
    internal class NoVowelsException : Exception
    {
        public NoVowelsException(string message) : base(message) { }
    }
}
