using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GradedUnitProject
{
    public class VehicleDB
    {
        public List<Vehicle> vehicles { get; set; }
        public List<Booking> bookings { get; set; }
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

        public List<Booking> Bookings
        {
            get { return bookings; }
        }

        

        public void populate()
        {
            vehicles.Add(new Vehicle("Ford", "Ka", "A", "30"));
            vehicles.Add(new Vehicle("Ford", "Focus", "B", "20"));
        }
    }
}