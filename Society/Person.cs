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
