using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Testapp.Helpers;

namespace Testapp.Models
{
    public class LeaderPrintoutDto : Model
    {
        string barangay;
        int barangayID;
        int purokID;
        int count_;
        int clusterID;
        string barangayCoordinator;
        string purokLeader;
        string purokName;
        string clusterLeader;
        List<Person> voters;

        public string Barangay { get => barangay; set => barangay = value; }
        public string BarangayCoordinator { get => barangayCoordinator; set => barangayCoordinator = value; }
        public string PurokLeader { get => purokLeader!=null? purokLeader: "NO LEADER" ; set => purokLeader = value; }
        public string ClusterLeader { get => clusterLeader != null?clusterLeader: "NO LEADER"; set => clusterLeader = value; }
        public List<Person> Voters { get => voters; set => voters = value; }
        public int BarangayID { get => barangayID; set => barangayID = value; }
        public int PurokID { get => purokID; set => purokID = value; }
        public int ClusterID { get => clusterID; set => clusterID = value; }
        public int Count_ { get => count_; set => count_ = value; }
        public string PurokName { get => purokName!=null || purokName!= string.Empty?purokName:"NO PUROK"; set => purokName = value; }
    }
}
