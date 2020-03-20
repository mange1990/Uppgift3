using System;
using System.Collections.Generic;
using System.Text;

namespace Övning3
{
    class Pelican : Bird
    {
        public int FlyingDistance { get; set; }

        public Pelican(string name, int weight, int age, int wingSpan, int flyingDistance): base(name, weight, age, wingSpan)
        {
            FlyingDistance = flyingDistance;
        }

        public override string Stats()
        {
            return $"{base.Stats()}, Har flugit: {FlyingDistance} meter";
        }


    }
}
