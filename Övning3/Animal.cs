using System;
using System.Collections.Generic;
using System.Text;

namespace Övning3
{
    //9 svar: Här läggs nya attribut som alla djur ska ha
    class Animal
    {
        public string name { get; set; }
        public int weight { get; set; }
        public int age { get; set; }

        public Animal(string name, int weight, int age)
        {
            this.name = name;
            this.weight = weight;
            this.age = age;

       
       }

        public virtual string Stats()
        {
            return $"Namn: {name} , Vikt: {weight}, Ålder: {age}";
        }
       

    }
}
