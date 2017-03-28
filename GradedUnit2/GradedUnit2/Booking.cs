using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GradedUnit2
{
    class Booking
    {
        private string name;
        private string address;
        private string town;
        private string postcode;
        private string phoneno;

        public Booking(string n, string ad, string twn, string pst, string phone)
        {
            name = n;
            address = ad;
            town = twn;
            postcode = pst;
            phoneno = phone;
        }

        public Booking()
        {
            // TODO: Complete member initialization
        }
    }
}
