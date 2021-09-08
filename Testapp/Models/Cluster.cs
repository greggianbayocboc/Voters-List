using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Testapp.Helpers;

namespace Testapp.Models
{
    public class Cluster : Model
    {
        int id = -1;

        public int ID
        {
            get { return id; }
            set { id = value; }
        }

        int purok;

        public int Purok
        {
            get { return purok; }
            set { purok = value; }
        }

        string leader;

        public string Leader
        {
            get { return leader; }
            set { leader = value; }
        }

        List<Person> Voters;

        public override string ToString()
        {
            return Leader;
        }
        
        
        public Cluster(bool _saveable)
        {
            this.isSaveable = _saveable;
            this.leader = "NOT SET";
        }

        public Cluster()
        {
            // TODO: Complete member initialization
        }
    }
}
