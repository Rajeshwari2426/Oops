using System;
using OopsConcepts.Polymorphism;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OopsConcepts.Polymorphism
{
    class Dog : Animals
    {
        public void animalSound()
        {
            Console.WriteLine("Dog says Bow Bow");
        }
    }
   
}
