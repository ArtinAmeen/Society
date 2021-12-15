using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Society
{
    class Person
    {
        private int age;
        private string fName;
        private string lName;
        private double height;
        private double weight;

        // with the constructor below, we can instanciate Person without the need to
        // pass any arguments (we will have the possibility to do it later if we want to).
        public Person()
        {

        }
        //public Person(string fname, string lname)
        //{
        //    FName = fname;
        //    LName = lname;
        //}

        //public Person(string fname, string lname, int age, double height, double weight)
        //{
        //    FName = fname;
        //    LName = lname;
        //    Age = age;
        //    Height = height;
        //    Weight = weight;
        //}

        public int Age
        {
            set
            {
                if (value < 1)
                {
                    throw (new ArgumentException("Age can not be lower than 1"));
                }

                else
                {
                    age = value;
                }
            }

            get
            {
                return age;
            }
        }

        public string FName
        {
            set
            {
                if (value == null)
                {
                    throw new ArgumentNullException();
                }

                else if (value.Length < 2 || value.Length > 10)
                {
                    throw new ArgumentException("First name must be between 2 and 10 characters!");
                }

                else
                {
                    fName = value;
                }
            }

            get
            {
                return fName;
            }
        }

        public string LName
        {
            set
            {
                if (value == null)
                {
                    throw new ArgumentNullException();
                }

                else if (value.Length < 3 || value.Length > 15)
                {
                    throw new ArgumentException("Last name must be between 3 and 15 characters!");
                }

                else
                {
                    lName = value;
                }
            }

            get
            {
                return lName;
            }
        }

        public double Height
        {
            set
            {
                height = value;
            }

            get
            {
                return height;
            }

        }

        public double Weight
        {
            set
            {
                weight = value;
            }

            get
            {
                return weight;
            }
        }
    }
}
