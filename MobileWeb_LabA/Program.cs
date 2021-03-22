using System;
using System.Collections;

namespace MobileWeb_LabA
{
    class Program
    {
        static void Main(string[] args)
        {
            ArrayList zoo = new ArrayList();
            string resp = "";

            // Lines to Replace Begin Here
            zoo.Add(new Dog(true, "Bean"));
            zoo.Add(new Cat(9, "Charlie"));
            zoo.Add(new Teacher(44, "Stacy Read"));

            do
            {
                Decision userInput = new Decision();
                userInput.MakeDecision(zoo);
                Console.WriteLine("Do you want to add another animal?");
                resp = Console.ReadLine();
            } while (resp.ToUpper().Equals("Y"));
            // End Lines to Replace
            foreach (Talkable t in zoo)
            {
                printOut(t);
            }
        }

        public static void printOut(Talkable p)
        {
            Console.WriteLine(p.Name + " says " + p.Talk());
        }
    }
}
