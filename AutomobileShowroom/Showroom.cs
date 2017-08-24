using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomobileShowroom
{
    public class Showroom
    {
        public Showroom()
        {
            Vehicles = new Dictionary<string, Vehicle>();
        }
        public Dictionary<string, Vehicle> Vehicles { get;private set; }
        
    }
}
