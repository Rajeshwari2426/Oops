using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OopsConcepts.Classes
{
    public class Car
    {
        public string color = "Red";
        public int maxSpeed = 200;
        public string type = "Sedan";
        public int model;
        public bool sunRoof = false;

        public void Horn()
        {
            Console.WriteLine("Beep beep...");
        }
    }
    
}
