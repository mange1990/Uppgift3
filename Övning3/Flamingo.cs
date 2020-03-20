using System;
using System.Collections.Generic;
using System.Text;

namespace Övning3
{
    class Flamingo : Bird
    {
        public string FromCountry { get; set; }

        public Flamingo(string name, int weight, int age, int wingSpan, string fromCountry) : base(name, weight, age, wingSpan)
        {
            FromCountry = fromCountry;
        }

        public override string Stats()
        {
            return $"{base.Stats()}, Från: {FromCountry}";
        }
    }
}
