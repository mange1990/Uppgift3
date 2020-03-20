using System;
using System.Collections.Generic;
using System.Text;

namespace Övning3
{
    class NullPointerError : UserError
    {
        public override string UEMessage()
        {
            return "Du försöker anropa en metod på en null referens";
        }
    }
}
