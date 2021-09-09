using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Testapp.Helpers;

namespace Testapp.Models
{
    public class Barangay : Model
    {
 

        private string barangayName;

        public string BarangayName
        {
            get { return barangayName; }
            set { barangayName = value; }
        }
        private string coordinator;

        public string Coordinator
        {
            get { return coordinator; }
            set { coordinator = value; }
        }
        public List<Purok> Puroks;

        public Barangay()
        {

        }

        public Barangay(bool _saveable)
        {
            this.isSaveable = _saveable;
            this.barangayName = "NOT SET";
        }

        public Barangay(string name)
        {
            this.barangayName = name;
        }

        public Barangay(string _barangay_name, string _coordinator)
        {
            this.barangayName = _barangay_name;
            this.coordinator = _coordinator;
        }

        public override string ToString()
        {
            return barangayName;
        }
    }
}
