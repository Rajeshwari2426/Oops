using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OopsConcepts.Constructor
{
    class CarConstruct
    {
        public string model, color, type;
        public int maxSpeed;

        public CarConstruct(string modelName, string colorName, string typeName, int max_Speed)
        {
            model = modelName;
            color = colorName;
            type = typeName;
            maxSpeed = max_Speed;
        }
    }
    
}
