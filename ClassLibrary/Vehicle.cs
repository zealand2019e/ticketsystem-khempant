using System;
using System.Collections.Generic;
using System.Text;

namespace ClassLibrary
{
    public abstract class Vehicle
    {
        private double _price;
        private bool _brobizz;
        private string licensePlate;
        public DateTime Date { get; set; }
        public abstract string VehicleType();

        public virtual double Price()
        {
        }
    }
}
