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
                Person person1 = new Person();

                person1.FName = null;

                Console.WriteLine("Person 1 is " + person1.FName);

                person1.Age = 25;

                Console.WriteLine(person1 + " is " + person1.Age);

                PersonHandler pH = new PersonHandler();

                Console.WriteLine("--------------------------------");
                Person david = pH.CreatePerson(25, "David", "Andersson", 1.82, 76);
                Console.WriteLine(david.Age);
                pH.SetAge(david, 50);
                Console.WriteLine(david.Age);
                // int age = pH.GetAge(david);
                pH.Birthday(david);
                Console.WriteLine(david.Age);
                Console.WriteLine("--------------------------------");

                // person2.Birthday(person2.Ag);

                pH.outPrintInfo(david);


            }

            catch (Exception e)
            {
                Console.WriteLine("{0} thrown.", e.GetType().FullName);
            }


        }
    }
}
