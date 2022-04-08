using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Testapp.Helpers;

namespace Testapp.Models
{
    public class Person : Model
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
        int barangay;

        public int Barangay
        {
            get { return barangay; }
            set { barangay = value; }
        }
        int cluster;

        public int Cluster
        {
            get { return cluster; }
            set { cluster = value; }
        }
        int purok;

        public int Purok
        {
            get { return purok; }
            set { purok = value; }
        }
        int age;

        public int Age
        {
            get { return age; }
            set { age = value; }
        }
        string mayor = "INC";

        public string Mayor
        {
            get { return mayor; }
            set { mayor = value; }
        }
        string vice = "INC";

        public string Vice
        {
            get { return vice; }
            set { vice = value; }
        }
        string councilor1 = "INC";

        public string Councilor1
        {
            get { return councilor1; }
            set { councilor1 = value; }
        }
        string councilor2 = "INC";

        public string Councilor2
        {
            get { return councilor2; }
            set { councilor2 = value; }
        }
        string councilor3 = "INC";

        public string Councilor3
        {
            get { return councilor3; }
            set { councilor3 = value; }
        }
        string councilor4 = "INC";

        public string Councilor4
        {
            get { return councilor4; }
            set { councilor4 = value; }
        }
        string councilor5 = "INC";

        public string Councilor5
        {
            get { return councilor5; }
            set { councilor5 = value; }
        }
        string councilor6 = "INC";

        public string Councilor6
        {
            get { return councilor6; }
            set { councilor6 = value; }
        }
        string councilor7 = "INC";

        public string Councilor7
        {
            get { return councilor7; }
            set { councilor7 = value; }
        }
        string councilor8 = "INC";

        public string Councilor8
        {
            get { return councilor8; }
            set { councilor8 = value; }
        }
        string remarks = "";

        public string Remarks
        {
            get { return remarks; }
            set { remarks = value; }
        }

        int originalbarangay;

        public int Originalbarangay
        {
            get { return originalbarangay; }
            set { originalbarangay = value; }
        }

   
    }
}
