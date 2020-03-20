using System;
using System.Collections.Generic;
using System.Text;

namespace Övning3
{
    class Person
    {
        private int age;
        private string fname;
        private string lname;
        private double height;
        private double weight;

        public int Age
        {
            get { return age; }
            set { age = value; }
        }

        public string FName
        {
            get { return fname; }
            set { fname = value; }
        }
        public string LName
        {
            get { return lname; }
            set { lname = value; }
        }
        public double Height
        {
            get { return height; }
            set { height = value; }
        }

        public double Weight
        {
            get { return weight; }
            set { weight = value; }
        }



    }
}
