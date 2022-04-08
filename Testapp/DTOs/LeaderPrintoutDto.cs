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

public string Barangay
{
  get { return barangay; }
  set { barangay = value; }
}
        int barangayID;

public int BarangayID
{
  get { return barangayID; }
  set { barangayID = value; }
}
        int purokID;

public int PurokID
{
  get { return purokID; }
  set { purokID = value; }
}
        int count_;

public int Count_
{
  get { return count_; }
  set { count_ = value; }
}
        int clusterID;

public int ClusterID
{
  get { return clusterID; }
  set { clusterID = value; }
}
        string barangayCoordinator;

public string BarangayCoordinator
{
  get { return barangayCoordinator; }
  set { barangayCoordinator = value; }
}
        string purokLeader;
        string purokName;
        string clusterLeader;
        List<Person> voters;

public List<Person> Voters
{
  get { return voters; }
  set { voters = value; }
}

public string PurokLeader { get { return purokLeader != null ? purokLeader : "NO LEADER"; } set { purokLeader = value; } }
public string ClusterLeader { get { return clusterLeader != null ? clusterLeader : "NO LEADER"; } set { clusterLeader = value; } }
public string PurokName { get { return purokName != null || purokName != string.Empty ? purokName : "NO PUROK"; } set { purokName = value; } }
    }
}
