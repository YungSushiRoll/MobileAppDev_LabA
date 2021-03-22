using System;
using System.Collections.Concurrent;
using System.Collections;
using System.Text;

namespace MobileWeb_LabA
{
    class Decision
    {
        public Talkable MakeDecision(ArrayList zoo)
        {
            Talkable animal;
            string resp = "";
            bool friend = true;
                
            
            Console.WriteLine("What type of animal would you like to create?\n" +
                    "1. Dog\n" +
                    "2. Cat\n" +
                    "3. Teacher\n" +
                    "0. EXIT" +
                    "////////////////////////////////////////////////");

                resp = Console.ReadLine();

                switch(resp)
                {
                    case "1":
                        Console.WriteLine("What's the name of your dog?");
                        var dogName = Console.ReadLine();
                        animal = new Dog(friend, dogName);

                        Console.WriteLine("Is your dog friendly? Y/N");
                        var isFriend = Console.ReadLine();
                        if (isFriend.ToUpper().Equals("Y"))
                        {
                            friend = true;
                        } else
                        {
                            friend = false;
                        }
                        zoo.Add(animal);
                    break;
                    case "2":
                        Console.WriteLine("What's the name of your Cat?");
                        var catName = Console.ReadLine();

                        Console.WriteLine("How many mouses did your cat kill?");
                        var killCount = Console.ReadLine();
                        animal = new Cat(int.Parse(killCount), catName);
                        zoo.Add(animal);
                    break;
                    case "3":
                        Console.WriteLine("What's your name traveler?");
                        var yourName = Console.ReadLine();

                        Console.WriteLine("How old are you traveler?");
                        var age = Console.ReadLine();
                        animal = new Teacher(int.Parse(age), yourName);
                        zoo.Add(animal);
                    break;
                default:
                        animal = new Dog(false, "Something went wrong");
                        return animal;
                }

            return animal;
        }
    }
}
