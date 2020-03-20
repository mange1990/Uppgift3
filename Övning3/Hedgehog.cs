using System;
using System.Collections.Generic;
using System.Text;

namespace Övning3
{
    class Hedgehog : Animal
    {
        public int NrOfSpikes { get; set; }

        public Hedgehog(string name, int weight, int age, int nrOfSpikes): base(name, weight, age)
        {
            NrOfSpikes = nrOfSpikes;
        }

        public override string Stats()
        {
            return $"{base.Stats()}, NrOfSpikes: {NrOfSpikes}";
        }
    }
}
