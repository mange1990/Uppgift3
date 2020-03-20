using System;
using System.Collections.Generic;
using System.Text;

namespace Övning3
{
    class StackOverflowError : UserError
    {
        public override string UEMessage()
        {
            return "Stack overflow";
        }
    }
}
