using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OopsConcepts.Abstraction;
using OopsConcepts.Polymorphism;
using OopsConcepts.Inheritence;
using OopsConcepts.Encapsulation;
using OopsConcepts.Constructor;
using OopsConcepts.Classes;

namespace OopsConcepts
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Classes------------------------------------------------------------------
            Car ford = new Car();
            Console.WriteLine(ford.color);
            Console.WriteLine(ford.maxSpeed);
            ford.Horn();

            Car tesla = new Car();
            tesla.color = "Blue";
            tesla.maxSpeed = 250;
            tesla.model = 3;
            tesla.sunRoof = true;

            Console.WriteLine(tesla.color);
            Console.WriteLine(tesla.maxSpeed);
            Console.WriteLine(tesla.sunRoof);
            tesla.Horn();


            // Constructor -----------------------------------------------------------
            CarConstruct honda = new CarConstruct("City", "Black", "Sedan", 200);

            Console.WriteLine($"New car is Honda {honda.model}, Color:{honda.color} with max Speed {honda.maxSpeed} & type {honda.type}");



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
