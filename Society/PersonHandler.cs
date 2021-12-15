using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Society
{
    class PersonHandler
    {
        // we have two constructors below that can create a person, so no matter which one you use, you
        // will always have to pass the first and last name as arguments.
        public Person CreatePerson(string fname, string lname, int age, double height, double weight)
        {
            Person pers = new Person(fname, lname, age, height, weight);

            return pers;
        }

        public Person CreatePerson(string fname, string lname)
        {
            Person pers = new Person(fname, lname);

            return pers;
        }

        // when accessing this method, you can set a person's age by passing the person object and its new age as arguments.
        public void SetAge(Person pers, int age)
        {
            pers.Age = age;
        }

        // this method increments a person's age by one.
        public void Birthday(Person pers)
        {
            pers.Age++;
            Console.WriteLine($"Happy birthday, {pers.FName} {pers.LName}!");
        }

        // this method will print out different messages, depending on which fields (besides first and last name)
        // are zero or not.
        public void OutPrintInfo(Person pers)
        {
            if (pers.Height <= 0 && pers.Weight <= 0 && pers.Age < 1)
            {
                Console.WriteLine($"{pers.FName} {pers.LName} is a person we do not have much information about.");
            }

            else if (pers.Height <= 0 && pers.Weight <= 0)
            {
                Console.WriteLine($"{pers.FName} {pers.LName} is {pers.Age} years old.");
            }

            else if (pers.Weight <= 0 && pers.Age <= 0)
            {
                Console.WriteLine($"{pers.FName} {pers.LName} is {pers.Height} cm tall.");
            }

            else if (pers.Height <= 0 && pers.Age <= 0)
            {
                Console.WriteLine($"{pers.FName} {pers.LName} weighs {pers.Weight} kg.");
            }

            else if (pers.Height <= 0)
            {
                Console.WriteLine($"{pers.FName} {pers.LName} is {pers.Age} years old and weighs {pers.Weight} kg.");
            }

            else if (pers.Weight <= 0)
            {
                Console.WriteLine($"{pers.FName} {pers.LName} is {pers.Age} years old and {pers.Height} cm tall.");
            }

            else if (pers.Age <= 0)
            {
                Console.WriteLine($"{pers.FName} {pers.LName} is {pers.Height} cm tall and weighs {pers.Weight} kg.");
            }

            else
            {
                Console.WriteLine($"{pers.FName} {pers.LName} is {pers.Age} years old, {pers.Height} cm tall, and weighs {pers.Weight} kg.");
            }
        }

        // by calling this method, the person will change the current first name to a new one.
        public void ChangeFirstName(Person pers, string newFirstName)
        {
            Console.WriteLine($"{pers.FName} {pers.LName} has changed first name to {newFirstName}.");
            pers.FName = newFirstName;
        }

        // by calling this method, the person will grow by 2 centimetres.
        public void IncreaseHeight(Person pers)
        {
            pers.Height += 2;
            Console.WriteLine($"{pers.FName} {pers.LName} has grown by 2 centimetres.");
        }
    }
}