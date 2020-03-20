using System;
using System.Collections.Generic;
using System.Text;

namespace Övning3
{
    //8 Svar: Här läggs nya attribut som alla fåglar ska ha
    class Bird​ : Animal
    {
        public int WingSpan { get; set; }

        public Bird​(string name, int weight, int age, int wingSpan):base(name, weight, age)
        {
            WingSpan = wingSpan;
        }

        public override string Stats()
        {
            return $"{base.Stats()}, Vingbredd: {WingSpan}" ;
        }
    }
}
