using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Testapp.Helpers;

namespace Testapp.Models
{
    public class Purok : Model
    {
        int id = -1;

        public int ID
        {
            get { return id; }
            set { id = value; }
        }

        string purokName;

        public string PurokName
        {
            get { return purokName; }
            set { purokName = value; }
        }
        string leader;

        public string Leader
        {
            get { return leader; }
            set { leader = value; }
        }
        int barangay;

        public int Barangay
        {
            get { return barangay; }
            set { barangay = value; }
        }
        List<Cluster> Clusters;

        public override string ToString()
        {
            return purokName;
        }

        
        public Purok(bool _saveable)
        {
            this.isSaveable = _saveable;
            this.purokName = "NOT SET";
        }

        public Purok()
        {
            // TODO: Complete member initialization
        }
    }
}
