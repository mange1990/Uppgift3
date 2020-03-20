using System;
using System.Collections.Generic;

namespace Övning3
{
    class Program
    {
        static void Main(string[] args)  
        {
            //Kommer inte direkt åt variablerna, utan måste använda dess properties
            //   Person p = new Person();

            PersonHandler ph = new PersonHandler();
            Person p1 = ph.CreatePerson(24, "Anders", "Andersson", 179.5, 75.4);
            Person p2 = ph.CreatePerson(39, "Anna", "Svensson", 161.5, 64.2);
            Person p3 = ph.CreatePerson(25, "Johan", "Gustavsson", 182.2, 79.9);

            ph.SetAge(p1, 35);
            ph.SetFName(p2, "Emma");
            ph.SetLName(p3, "Johansson");
            ph.SetHeight(p1, 172.2);
            ph.SetWeight(p2, 66.8);
       
            List<Animal> animals = new List<Animal>();
            animals.Add(new Bird("Anders", 65, 15, 3));
            animals.Add(new Horse("Elsa", 252, 18, 45));
            animals.Add(new Swan("Sven", 10, 7, 4, "Vit"));
            animals.Add(new Dog("Saga", 21, 2, "Pudel"));
            animals.Add(new Pelican("Emma", 8, 4, 1 , 250));

            foreach (Animal animal in animals)
            {
                Console.WriteLine(animal);
            }

            List<Dog> dogs = new List<Dog>();
            // dogs.Add(new Horse("Pelle", 185, 19, 55));
            //7 Svar : Fungerar inte eftersom Horse inte är en subklass till Dog
            //8 Listan måste vara av typen Object för att kunna lagra vilken typ av objekt som helst

            //11 svar: Går igenom djuren och skriver ut dess stats() metod. Eftersom den är virtual så går programmet igenom och kollar subklasserna på den aktuella animal variabeln ifall den har en egen implementation av stats()
           //Är exempelvis animal variabeln av typen dog så anropas dog-klassens stats() metod ifall det finns någon annars går det uppåt i arvskedjan och kollar dess basklass o.s.v. tills den hittar en stats() metod som programmet anropar
            foreach (Animal animal in animals)
            {
                Console.WriteLine(animal.Stats());  
            }

            foreach (Animal animal in animals)
            {
                if (animal.GetType().Name == "Dog")
                {
                    Console.WriteLine(animal.Stats());
                }
            }

            //kommer inte åt eat metoden i Dog-klassen för Listan med Animals
            //Eftersom animal helt enkelt inte har någon eat metod 
            //Vi måste casta animal till en dog, dock behöver vi vara säkra på att det verkligen är en dog annars får vi invalidcastexception
            //Det gör vi på samma sätt som if-satsen ovan
            foreach (Animal animal in animals)
            {
                Console.WriteLine(animal.Stats());
                if (animal.GetType().Name == "Dog")
                {
                    Dog dog = (Dog) animal;
                    Console.WriteLine(dog.eat());
                }
            }

            List<UserError> usererrors = new List<UserError>();
            usererrors.Add(new NumericInputError());
            usererrors.Add(new TextInputError());
            usererrors.Add(new NullPointerError());
            usererrors.Add(new StackOverflowError());
            usererrors.Add(new InvalidArgumentError());
            foreach (UserError userError in usererrors)
            {
                Console.WriteLine(userError.UEMessage());
            }

            //11 svar: Det ger en bra flexibilitet till sin kod. Att man till exempel kan skapa en lista med animal och läggs alla animals objekt i listan
            //12 svar: det förbättrar koden genom att man till exempel skriver en rad kod som anropar en metod men som i själva verket anropar olika metoder beroende på vilken subklass det är. 
            //Lättare att återanvända kod så att man behöver skriva mindre och tydligare kod helt enkelt.
            //13 svar: I ett interface saknar alla metoder implementation medan i en abstract klass kan det finnas metoder både med och utan implementation 
            //Man kan i en klass implementera hur många interface som helst i en klass medan vid arv kan man bara ärva en klass
            //Fördelen med interface är att klasser inte behöver ingå i en arvshierarki och ha en is a relation vilket ger större flexibilitet
        }


    }
}
