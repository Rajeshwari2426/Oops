using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OopsConcepts.Abstraction;
using OopsConcepts.Polymorphism;
using OopsConcepts.Inheritence;
using OopsConcepts.Encapsulation;

namespace OopsConcepts
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Encapsulation -------------------------------------------------------
            Encapsulating person = new Encapsulating();
            person.Name = "Tony";
            Console.WriteLine(person.Name);


            //Inheritance-------------------------------------------------------------
            DerivedCar company = new DerivedCar();
            Console.WriteLine( company.brand +company.type +" " + company.color +" " + company.maxSpeed);

             
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
