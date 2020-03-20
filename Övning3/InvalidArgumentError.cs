using System;
using System.Collections.Generic;
using System.Text;

namespace Övning3
{
    class InvalidArgumentError : UserError
    {
        public override string UEMessage()
        {
            return "Du har angett ett felaktigt argument";
        }
    }
}
