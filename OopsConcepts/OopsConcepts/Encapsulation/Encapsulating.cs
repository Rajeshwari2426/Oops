using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OopsConcepts.Encapsulation
{
        class Encapsulating
        {
            private string name;
            public string Name
            {
                get { return name; }
                set { name = value + "Stark"; }
            }

        }
    
}
