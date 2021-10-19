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
        string lastname;
        string fullname;
        string precinct;
        string address;
        int barangay;
        int cluster;
        int purok;
        int age;
        string birthdate;

        string mayor = "INC";
        string vice = "INC";
        string councilor1 = "INC";
        string councilor2 = "INC";
        string councilor3 = "INC";
        string councilor4 = "INC";
        string councilor5 = "INC";
        string councilor6 = "INC";
        string councilor7 = "INC";
        string councilor8 = "INC";

        public string Firstname { get => firstname; set => firstname = value; }
        public string Lastname { get => lastname; set => lastname = value; }
        public string Fullname { get => fullname; set => fullname = value; }
        public string Precinct { get => precinct; set => precinct = value; }
        public string Address { get => address; set => address = value; }
        public int Barangay { get => barangay; set => barangay = value; }
        public int Cluster { get => cluster; set => cluster = value; }
        public int Purok { get => purok; set => purok = value; }
        public string Mayor { get => mayor; set => mayor = value; }
        public string Vice { get => vice; set => vice = value; }
        public string Councilor1 { get => councilor1; set => councilor1 = value; }
        public string Councilor2 { get => councilor2; set => councilor2 = value; }
        public string Councilor3 { get => councilor3; set => councilor3 = value; }
        public string Councilor4 { get => councilor4; set => councilor4 = value; }
        public string Councilor5 { get => councilor5; set => councilor5 = value; }
        public string Councilor6 { get => councilor6; set => councilor6 = value; }
        public string Councilor7 { get => councilor7; set => councilor7 = value; }
        public string Councilor8 { get => councilor8; set => councilor8 = value; }
        public int Age { get => age; set => age = value; }
        public string Birthdate { get => birthdate; set => birthdate = value; }
    }
}
