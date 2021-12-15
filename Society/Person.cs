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

        // with the constructor below (that's presently a comment), we can instantiate Person without
        // the need to pass any arguments.

        //public Person()
        //{

        //}

        // with the constructor below, you can create a person and only give the person a first and last name.
        public Person(string fname, string lname)
        {
            FName = fname;
            LName = lname;
        }

        public Person(string fname, string lname, int age, double height, double weight)
        {
            FName = fname;
            LName = lname;
            Age = age;
            Height = height;
            Weight = weight;
        }

        // a person can not have an age of zero or below.
        public int Age
        {
            set
            {
                if (value < 1)
                {
                    throw (new ArgumentException("The age of the person is invalid. It cannot be under 1."));
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

        // we can not give a person a first name shorter than 2 characters or longer than 10 characters, or set it at null.
        public string FName
        {
            set
            {
                if (value == null)
                {
                    throw new ArgumentNullException();
                }

                else if (value.Length < 2)
                {
                    throw new ArgumentException("First name is too short. It has to be between 2 and 10 characters.");
                }

                else if (value.Length > 10)
                {
                    throw new ArgumentException("First name is too long. It has to be between 2 and 10 characters.");
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

        // we can not give a person a last name shorter than 3 characters or longer than 15 characters, or set it at null.
        public string LName
        {
            set
            {
                if (value == null)
                {
                    throw new ArgumentNullException();
                }

                else if (value.Length < 3)
                {
                    throw new ArgumentException("Last name is too short. It has to be between 3 and 15 characters.");
                }

                else if (value.Length > 15)
                {
                    throw new ArgumentException("Last name is too long. It has to be between 3 and 15 characters.");
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
