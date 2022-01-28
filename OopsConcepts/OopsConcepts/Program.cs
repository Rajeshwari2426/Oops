using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OopsConcepts.Abstraction;
using OopsConcepts.Polymorphism;

namespace OopsConcepts
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Polymorphism-----------------------------------------------------------
            Animals myAnimal = new Animals();
            myAnimal.animalSound();

            Dog myDog = new Dog();
            myDog.animalSound();

            //Abstraction-------------------------------------------------------------

            Snake mySnake = new Snake();
            mySnake.animalSound();
            mySnake.sleep();


            Console.ReadLine();
        }
    }
}
