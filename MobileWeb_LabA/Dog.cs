using System;
using System.Collections.Generic;
using System.Text;

namespace MobileWeb_LabA
{
    class Dog : Pet, Talkable
    {
        public bool Friendly { get; set; }

        public Dog(bool friendly, string name) : base(name)
        {
            Friendly = friendly;
        }

        public string Talk()
        {
            return "Bark";
        }

        override
        public string ToString()
        {
            return "Dog: " + "name = " + Name + " friendly = " + Friendly;
        }
    }
}
