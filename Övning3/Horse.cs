using System;
using System.Collections.Generic;
using System.Text;

namespace Övning3
{
    class Horse : Animal
    {
        public int MaxSpeed { get; set; }

        public Horse(string name, int weight, int age, int maxSpeed): base(name, weight, age)
        {
            MaxSpeed = maxSpeed;
        }
        public override string Stats()
        {
            return $"{base.Stats()}, max hastighet: {MaxSpeed}";
        }
    }
}
