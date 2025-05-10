using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReviewSession_4
{
    class FileTooLargeException : Exception
    {
        public FileTooLargeException(string message) : base(message) { }
    }
}
