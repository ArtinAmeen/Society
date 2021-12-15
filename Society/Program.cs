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
                //Person person1 = new Person();
                //person1.FName = "Art";
                //person1.LName = "Cech";
                //person1.Age = 25;
                //Console.WriteLine("Person 1 is " + person1.FName);
                //Console.WriteLine(person1.FName + " is " + person1.Age);

                PersonHandler pH = new PersonHandler();

                Console.WriteLine("--------------------------------");
                Person david = pH.CreatePerson("David", "Andersson", 25, 182, 76);
                Console.WriteLine(david.Age);
                pH.SetAge(david, 50);
                Console.WriteLine(david.Age);
                // int age = pH.GetAge(david);
                pH.Birthday(david);
                Console.WriteLine(david.Age);
                Console.WriteLine("--------------------------------");

                // person2.Birthday(person2.Ag);

                pH.OutPrintInfo(david);
                pH.ChangeFirstName(david, "Jonas");

                pH.IncreasedHeight(david);

                Console.WriteLine(david.Height);

                Person anna = pH.CreatePerson("Anna", "Josefsson", 28, 168, 60);

                pH.OutPrintInfo(anna);
                pH.OutPrintInfo(david);

                Person p1 = pH.CreatePerson("Erik", "Eriksson");
                pH.OutPrintInfo(p1);

                // error, we must have both the first and the last name of the person and as two separate arguments.
                // Person p2 = pH.CreatePerson("Peter");

                Person p3 = pH.CreatePerson("Jan", "Persson");
                pH.SetAge(p3, 23);
                pH.OutPrintInfo(p3);
            }

            catch (Exception e)
            {
                Console.WriteLine("{0} thrown.\n{1}", e.GetType().FullName, e.Message);
            }
        }
    }
}
