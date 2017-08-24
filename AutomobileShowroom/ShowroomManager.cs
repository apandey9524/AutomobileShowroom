using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomobileShowroom
{
    public class ShowroomManager
    {
        public ShowroomManager(Showroom showroom,Logger logger)
        {
            _showroom = showroom;
            _logger = logger;
        }
        private Showroom _showroom;
        private List<Vehicle> _vehiclesOnTestDrive;
        private Logger _logger;

        public bool TryProcessRequest(Service service,Vehicle vehicle,out Invoice invoice,uint rentPeriod=0)
        {
            switch(service)
            {
                case Service.maintenance:invoice = new Invoice(service, vehicle);_logger.Log(invoice); return true ;
                case Service.rent:invoice = new Invoice(service, vehicle, rentPeriod); _logger.Log(invoice); return true;
                case Service.sell: invoice= new Invoice(service, vehicle); _logger.Log(invoice); return true;
                case Service.testdrive: invoice = new Invoice(service, vehicle); _logger.Log(invoice); return true;
                default:invoice = null; return false;
            }

        }
        public bool AddVehicle(string productId, Vehicle vehicle)
        {
            if (ValidateID(productId))
            {
                _showroom.Vehicles.Add(productId, vehicle);
                return true;
            }
            else
            {
                return false;
            }
        }
        private bool ValidateID(string productId)
        {
            if (_showroom.Vehicles.ContainsKey(productId) == false)
            {
                return true;
            }
            return false;
        }
        public bool TryRemoveVehicle(string productId, out Vehicle vehicle)
        {
            return (_showroom.Vehicles.TryGetValue(productId, out vehicle));
        }
    }
}
