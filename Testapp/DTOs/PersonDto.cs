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
        
        string lastname;

        string fullname;
       
        string precinct;

        string address;

        string barangay;

        string purok;

        string cluster;

        public string Firstname { get => firstname; set => firstname = value; }
        public string Lastname { get => lastname; set => lastname = value; }
        public string Fullname { get => fullname; set => fullname = value; }
        public string Precinct { get => precinct; set => precinct = value; }
        public string Address { get => address; set => address = value; }
        public string Barangay { get => barangay; set => barangay = value; }
        public string Purok { get => purok; set => purok = value; }
        public string Cluster { get => cluster; set => cluster = value; }
    }
}
