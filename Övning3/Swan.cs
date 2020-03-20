using System;
using System.Collections.Generic;
using System.Text;

namespace Övning3
{
    class Swan : Bird
    {
        public string Color { get; set; }

        public Swan(string name, int weight, int age, int wingSpan, string color):base(name, weight, age, wingSpan)
        {
            Color = color;
        }

        public override string Stats()
        {
            return $"{base.Stats()}, Färg: {Color}";
        }
    }
}
