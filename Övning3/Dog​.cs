using System;
using System.Collections.Generic;
using System.Text;

namespace Övning3
{
    class Dog​ : Animal
    {
        public string BreedOfDog { get; set; }

        public Dog​(string name, int weight, int age, string breedOfDog): base(name, weight, age)
        {
            BreedOfDog = breedOfDog;
        }

        public override string Stats()
        {
            return $"{base.Stats()}, Hundras: {BreedOfDog}" ;
        }

        public string eat()
        {
            return "Äter";
        }

    }
}
