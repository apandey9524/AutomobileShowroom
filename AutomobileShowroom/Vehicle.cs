using System;
using System.Collections.Generic;
using AutomobileShowroom.Constants;
using System.Text;
using System.Threading.Tasks;

namespace AutomobileShowroom
{
    public class Vehicle
    {
        public Vehicle(VehicleCategory category,string model,float price,float maintananceCost,float rentPerDay)
        {
            Category = category;
            Model = model;
            Price = price;
            MaintananceCost = maintananceCost;
            RentPerDay = rentPerDay;
        }
        public float RentPerDay { get;private set; }
        public VehicleCategory Category { get; private set; }
        public string Model { get; private set; }
        public float Price { get; private set; }
        public float MaintananceCost { get;private set; }
    }
}
