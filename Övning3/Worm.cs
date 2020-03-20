using System;
using System.Collections.Generic;
using System.Text;

namespace Övning3
{
    class Worm : Animal
    {
        public bool IsPoisonous { get; set; }

        public Worm(string name, int weight, int age, bool isPoisonous) : base(name, weight, age)
        {
            IsPoisonous = isPoisonous;
        }

        public override string Stats()
        {
            string text = $"{base.Stats()}, Giftig: ";
            text += IsPoisonous ? "Ja" : "Nej";
            return text;
        }
    }
}
