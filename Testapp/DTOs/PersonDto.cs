using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Testapp.Helpers;

namespace Testapp.Models
{
    public class PersonDto : Model
    {

        string firstname;

        public string Firstname
        {
            get { return firstname; }
            set { firstname = value; }
        }

        string lastname;

        public string Lastname
        {
            get { return lastname; }
            set { lastname = value; }
        }

        string fullname;

        public string Fullname
        {
            get { return fullname; }
            set { fullname = value; }
        }

        string precinct;

        public string Precinct
        {
            get { return precinct; }
            set { precinct = value; }
        }

        string address;

        public string Address
        {
            get { return address; }
            set { address = value; }
        }

        string barangay;

        public string Barangay
        {
            get { return barangay; }
            set { barangay = value; }
        }

        string purok;

        public string Purok
        {
            get { return purok; }
            set { purok = value; }
        }

        string cluster;

        public string Cluster
        {
            get { return cluster; }
            set { cluster = value; }
        }

       
    }
}
