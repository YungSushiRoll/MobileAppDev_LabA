using System;
using System.Collections.Generic;
using System.Text;

namespace MobileWeb_LabA
{
    abstract class Person
    {
        public string Name { get; set; }

        public Person(string name)
        {
            Name = name;
        }
    }
}
