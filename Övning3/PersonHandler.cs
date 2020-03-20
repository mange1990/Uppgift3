using System;
using System.Collections.Generic;
using System.Text;

namespace Övning3
{
    class PersonHandler
    {
        public void SetAge(Person pers, int age)
        {
            pers.Age = age;
        }

        public void SetFName(Person pers, string fname)
        {
            pers.FName = fname;
        }

        public void SetLName(Person pers, string lname)
        {
            pers.LName = lname;
        }

        public void SetHeight(Person pers, double height)
        {
            pers.Height = height;
        }

        public void SetWeight(Person pers, double weight)
        {
            pers.Weight = weight;
        }

        public Person CreatePerson(int age, string fname, string lname, double height, double weight)
        {
            Person p = new Person();
            SetAge(p, age);
            SetFName(p, fname);
            SetLName(p, lname);
            SetHeight(p, height);
            SetWeight(p, weight);
 
            return p;
        }
     


    }
}
