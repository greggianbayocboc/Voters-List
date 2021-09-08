using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Testapp.Helpers;

namespace Testapp.Models
{
    public class Person : Model
    {
        int id;

        public int ID
        {
            get { return id; }
            set { id = value; }
        }
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
        int barangay;

        public int Barangay
        {
            get { return barangay; }
            set { barangay = value; }
        }
        int purok;

        public int Purok
        {
            get { return purok; }
            set { purok = value; }
        }
        int cluster;

        public int Cluster
        {
            get { return cluster; }
            set { cluster = value; }
        }


    }
}
