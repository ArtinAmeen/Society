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

        public Person(int age, string fname, string lname, double height, double weight)
        {
            Age = age;
            FName = fname;
            LName = lname;
            Height = height;
            Weight = weight;
        }

        public Person()
        {

        }

        public int Age
        {
            set
            {
                if (value < 1)
                {
                    throw (new ArgumentException("age can not be lower than 1"));
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
                    throw new ArgumentException();
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
                    throw new ArgumentException();
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

        public void Birthday(int age)
        {
            ++age;
        }
    }
}
