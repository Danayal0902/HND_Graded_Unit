using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GradedUnitProject
{
    public class Vehicle
    {

        Vehicle vehicles = new Vehicle();
        VehicleDB vdb;
        List<Vehicle> vl;

        private string p1;
        private string p2;
        private string p3;
        private string p4;

        public string manufacturer { get; set; }
        public string model { get; set; }
        public string group { get; set; }
        public int available { get; set; }


        public override string ToString()
        {
            return manufacturer + " " + model + " " + group + " " + available;
        }

        public Vehicle(string man, string mod, string grp, int av)
        {
            manufacturer = man;
            model = mod;
            group = grp;
            available = av;

            if (group == "A")
                available = 10;
            if (group == "B")
                available = 20;
            if (group == "C")
                available = 30;
            if (group == "D")
                available = 5;
            if (group == "E")
                available = 5;
            if (group == "Small Wheel")
                available = 20;
            if (group == "Long Wheel")
                available = 20;
            if (group == "Luton")
                available = 5;
        }



        public Vehicle()
            : base()
        {

        }

        public Vehicle(string p1, string p2, string p3, string p4)
        {
            // TODO: Complete member initialization
            this.p1 = p1;
            this.p2 = p2;
            this.p3 = p3;
            this.p4 = p4;
        }
    }
}

        