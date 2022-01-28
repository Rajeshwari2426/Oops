using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OopsConcepts.Abstraction;

namespace OopsConcepts
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Abstraction-------------------------------------------------------------
            
            Snake mySnake = new Snake();
            mySnake.animalSound();
            mySnake.sleep();


            Console.ReadLine();
        }
    }
}
