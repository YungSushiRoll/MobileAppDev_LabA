using System;
using System.Collections.Generic;
using System.Text;

namespace MobileWeb_LabA
{
    class Cat : Pet, Talkable
    {
        public int MousesKilled { get; set; }

        public Cat(int mousesKilled, string name) : base(name)
        {
            MousesKilled = mousesKilled;
        }

        public void AddMouse()
        {
            MousesKilled++;
        }

        public string Talk()
        {
            return "Meow";
        }

        override
        public string ToString()
        {
            return "Cat: " + "name = " + Name + " mousesKilled = " + MousesKilled;
        }
    }
}
