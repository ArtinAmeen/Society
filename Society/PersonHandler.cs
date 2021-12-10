using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Society
{
    class PersonHandler
    {
        public void SetAge(Person pers, int age)
        {
            pers.Age = age;
        }

        public Person CreatePerson(int age, string fname, string lname, double height, double weight)
        {
            Person pers = new Person(age, fname, lname, height, weight);

            return pers;
        }

        public void Birthday(Person pers)
        {
            pers.Age++;
            Console.WriteLine("Happy birthday " + pers.FName + "!");
        }

        public void OutPrintInfo(Person pers)
        {
            Console.WriteLine("Age: " + pers.Age);
            Console.WriteLine("First name: " + pers.FName);
            Console.WriteLine("Last name: " + pers.LName);
            Console.WriteLine("Height: " + pers.Height);
            Console.WriteLine("Weight: " + pers.Weight);
        }

        public void FirstNameChange (Person pers, string firstName)
        {
            pers.FName = firstName;
        }
    }
}