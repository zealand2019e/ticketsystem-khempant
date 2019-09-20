using System;
using System.Collections.Generic;
using System.Text;

namespace ClassLibrary
{/// <summary>
/// This is my Car Class
/// </summary>
    public class Car:Vehicle
    {
        public override double Price()
        {
            return 240;
        }
        public string VechileType()
        {
            return Car;
        }
    }
}
