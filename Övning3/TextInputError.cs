using System;
using System.Collections.Generic;
using System.Text;

namespace Övning3
{
    class TextInputError : UserError
    {
        public override string UEMessage()
        {
            return "You tried to use a text input in anumericonly field. This fired an error!";
        }
    }
}
