//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace Society
//{
//    class PersonHandler
//    {
//        public Person CreatePerson(string fname, string lname, int age, double height, double weight)
//        {
//            Person pers = new Person(fname, lname, age, height, weight);

//            return pers;
//        }        
        
//        public Person CreatePerson(string fname, string lname)
//        {
//            Person pers = new Person(fname, lname);

//            return pers;
//        }

//        public void SetAge(Person pers, int age)
//        {
//            pers.Age = age;
//        }

//        public void Birthday(Person pers)
//        {
//            pers.Age++;
//            Console.WriteLine("Happy birthday " + pers.FName + "!");
//        }

//        public void OutPrintInfo(Person pers)
//        {
//            Console.WriteLine($"{pers.FName} {pers.LName} is {pers.Age} years old, {pers.Height} cm tall, and weighs {pers.Weight} kg");
//        }

//        public void FirstNameChange (Person pers, string firstName)
//        {
//            pers.FName = firstName;
//        }

//        public void IncreasedHeight (Person pers)
//        {
//            pers.Height += 2;
//        }
//    }
//}