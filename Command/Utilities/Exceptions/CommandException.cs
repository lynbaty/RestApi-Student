using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Command.Utilities.Exceptions
{
    public class CommandException : Exception
    {
       
        public CommandException()
        {
        }

        public CommandException(string message)
            : base(message)
        {
        }

        public CommandException(string message, Exception inner)
            : base(message, inner)
        {
        }
       
    }
}
 