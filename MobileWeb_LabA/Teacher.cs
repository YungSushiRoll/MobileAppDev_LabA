using System;
using System.Collections.Generic;
using System.Text;

namespace MobileWeb_LabA
{
    class Teacher : Person, Talkable
    { 
        public int Age { get; set; }

        public Teacher(int age, string name) : base(name)
        {
            Age = age;
        }

        public string Talk()
        {
            return "Don't forget to do the addigned reading!";
        }
    }
}
