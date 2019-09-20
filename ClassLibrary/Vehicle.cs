using System;
using System.Collections.Generic;
using System.Text;

namespace ClassLibrary
{
    public  class Vehicle
    {
        public DateTime Date { get; set; }
        public bool Brobizz { get; set; }
        public  string VehicleType()
        {

        }
        public string _price;
        public string LicensePlate
        {
            get
            {
                return LicensePlate;
            }
            set
            {
                if (value.Length > 7)
                {
                    throw new Exception("License plate is too long");
                }
                else
                {
                    LicensePlate = value;
                }
            }
        }
            
                public virtual double Price()
                {

                }
            }
        }
    

