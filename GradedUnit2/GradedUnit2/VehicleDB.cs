using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GradedUnit2
{
    public class VehicleDB
    {
        public List<Vehicle> vehicles { get; set; }
        
        private static VehicleDB instance;


        public static VehicleDB Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new VehicleDB();
                    instance.populate();
                }
                return instance;
            }
        }

        public List<Vehicle> Vehicles
        {
            get { return vehicles; }
        }

        public VehicleDB()
        {
            vehicles = new List<Vehicle>();
        }

        



        public void populate()
        {
            
        }
    }
}
