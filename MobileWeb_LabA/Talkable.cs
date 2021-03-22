using System;
using System.Collections.Generic;
using System.Text;

namespace MobileWeb_LabA
{
    interface Talkable
    {
        string Talk();

        public string Name
        {
            get { return Name; }
        }
    }
}
