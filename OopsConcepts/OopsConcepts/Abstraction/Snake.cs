using System;
using OopsConcepts.Abstraction;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OopsConcepts.Abstraction
{
    class Snake : Animal
    {
        public override void animalSound()
        {
            Console.WriteLine("The snake sounds Hissss");
        }
    }
    
}
