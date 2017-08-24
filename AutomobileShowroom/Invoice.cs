using System;
using System.Collections.Generic;
using AutomobileShowroom.Constants;
using System.Text;
using System.Threading.Tasks;

namespace AutomobileShowroom
{
    public class Invoice
    {
        public Invoice(Service service,Vehicle vehicletobeserviced)
        {
            ServiceProvided = service;
            vehicle = vehicle;
            Amount = GetServiceCharge();
            Date = DateTime.Now;
        }
        public Invoice(Service service, Vehicle vehicletobeserviced,uint rentPeriod)
        {
            ServiceProvided = service;
            vehicle = vehicle;
            Amount = GetServiceCharge(rentPeriod);
            Date = DateTime.Now;
        }

        public Service ServiceProvided { get;private set; }
        public float Amount { get; private set; }
        public DateTime Date { get; private set; }
        public Vehicle vehicle { get; private set; }
        private float GetServiceCharge()
        {
            if (ServiceProvided == Service.sell)
            {
                return vehicle.Price;
            }
            else if(ServiceProvided==Service.maintenance)
            {
                return vehicle.MaintananceCost;
            }
            else
            {
                return 0;   //testdrive
            }
        }
        private float GetServiceCharge(uint rentPeriod)
        {
            return vehicle.RentPerDay* rentPeriod;
        }
    }
}
