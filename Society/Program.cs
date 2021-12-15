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
                person1.FName = "";
                person1.LName = "Cech";
                person1.Age = 25;
                Console.WriteLine("Person 1 is " + person1.FName);
                Console.WriteLine(person1 + " is " + person1.Age);

                //PersonHandler pH = new PersonHandler();

                //Console.WriteLine("--------------------------------");
                //Person david = pH.CreatePerson("David", "Andersson", 25, 182, 76);
                //Console.WriteLine(david.Age);
                //pH.SetAge(david, 50);
                //Console.WriteLine(david.Age);
                //// int age = pH.GetAge(david);
                //pH.Birthday(david);
                //Console.WriteLine(david.Age);
                //Console.WriteLine("--------------------------------");

                //// person2.Birthday(person2.Ag);

                //pH.OutPrintInfo(david);
                //pH.FirstNameChange(david, "Jonas");

                //Console.WriteLine(david.FName);

                //pH.IncreasedHeight(david);

                //Console.WriteLine(david.Height);

                //Person anna = pH.CreatePerson("Anna", "Josefsson", 28, 168, 60);

                //pH.OutPrintInfo(anna);
                //pH.OutPrintInfo(david);

                //Person p1 = pH.CreatePerson("Erik", "Eriksson");
                //p1.Age = 11;
            }

            catch (Exception e)
            {
                Console.WriteLine("{0} thrown.", e.GetType().FullName);
            }
        }
    }
}
