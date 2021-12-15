using System;
using Society;

namespace Society
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                // below is an instance of the class Person. It is possible to access every field in the
                // Person class via the name of the object.

                //Person person1 = new Person("Art", "Cech");
                //person1.Age = 25;
                //person1.Height = 188;
                //person1.Weight = 80;
                //Console.WriteLine($"Person 1 is called {person1.FName} {person1.LName}");
                //Console.Write($"{person1.FName} is {person1.Age} years old, is {person1.Height} cm tall. ");
                //Console.WriteLine($"He also weighs {person1.Weight} kg.");

                PersonHandler ph = new PersonHandler();

                //pH.SetAge(person1, 22);
                //Console.WriteLine(person1.FName + " is now " + person1.Age + " years old");

                Person person2 = ph.CreatePerson("David", "Andersson", 24, 182, 76);
                Console.WriteLine($"{person2.FName} {person2.LName} has an age of {person2.Age} and a weight of {person2.Weight} kg.");
                Console.WriteLine();
                ph.SetAge(person2, 40);
                Console.WriteLine($"{person2.FName} has now an age of {person2.Age}.");
                ph.Birthday(person2);
                Console.WriteLine($"You are now {person2.Age} years old.");
                Console.WriteLine();

                Person person3 = ph.CreatePerson("Anna", "Josefsson", 28, 168, 60);
                ph.OutPrintInfo(person3);
                Console.WriteLine();

                Person person4 = ph.CreatePerson("Erik", "Eriksson");
                ph.OutPrintInfo(person4);
                Console.WriteLine();

                ph.ChangeFirstName(person4, "Jonas");
                Console.WriteLine($"His current name is now {person4.FName} {person4.LName}.");

                // error, we must have both the first and the last name of the person and as two separate arguments.
                // Person p5 = pH.CreatePerson("Peter");

                Person person6 = ph.CreatePerson("Jan", "Persson");
                person6.Height = 179.5;
                ph.OutPrintInfo(person6);
                Console.WriteLine();

                ph.IncreaseHeight(person6);
                Console.WriteLine($"He is now {person6.Height} cm tall.");
            }

            catch (Exception e)
            {
                Console.WriteLine("{0} thrown.\n{1}", e.GetType().FullName, e.Message);
            }
        }
    }
}
