using System;
using System.Collections.Generic;
using System.Text;

namespace MobileWeb_LabA
{
    abstract class Pet
    {
        public string Name { get; set; }

        public Pet(string name)
        {
            Name = name;
        }
    }
}
