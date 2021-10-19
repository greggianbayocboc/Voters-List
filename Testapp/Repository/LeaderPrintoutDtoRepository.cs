using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Testapp;
using Testapp.Helpers;
using Testapp.Models;

namespace gregg.Repository
{
    public class LeaderPrintoutDtoRepository : DatabaseConnect<LeaderPrintoutDto>
    {


        public List<LeaderPrintoutDto> getGroupedReport() {
            return getGroupedReport("");
        }
        public List<LeaderPrintoutDto> getGroupedReport(string where) {
            string query1 = @"SELECT        Barangay.BarangayName AS Barangay, Barangay.ID AS BarangayID, Cluster.Leader AS ClusterLeader, COUNT(*) AS Count_, Barangay.Coordinator AS BarangayCoordinator, Purok.Leader AS PurokLeader,Purok.PurokName, Cluster.ID AS ClusterID,
                          Purok.ID AS PurokID
FROM            (((Person LEFT OUTER JOIN
                         Barangay ON Barangay.ID = Person.Barangay) LEFT OUTER JOIN
                         Purok ON Purok.ID = Person.Purok) LEFT OUTER JOIN
                         Cluster ON Cluster.ID = Person.Cluster) " + where +@" 
GROUP BY Barangay.BarangayName, Barangay.ID, Cluster.Leader, Purok.PurokName, Barangay.Coordinator, Purok.Leader, Cluster.ID, Purok.ID";
            return this.getListCustomQuery(query1);
        }

        public List<Person> getVoters(int barangayID, int purokID, int clusterID)
        {
            string query = @"SELECT        Person.Fullname, Person.Precinct
FROM            (((Person LEFT OUTER JOIN
                         Barangay ON Barangay.ID = Person.Barangay) LEFT OUTER JOIN
                         Purok ON Purok.ID = Person.Purok) LEFT OUTER JOIN
                         Cluster ON Cluster.ID = Person.Cluster) ";

            string barangayID_ = barangayID != 0 ? " = " + barangayID.ToString() : "IS NULL";
            string purokID_ = purokID != 0 ? " = " + purokID.ToString() : "IS NULL";
            string clusterID_ = clusterID != 0 ? " = " + clusterID.ToString() : "IS NULL";


            string whereClause = $"WHERE (Barangay.ID {barangayID_}) AND (Purok.ID {purokID_}) AND (Cluster.ID {clusterID_})";


            return Mapper.ConvertDataTable<Person>(this.ExecuteTabularQuery(query + whereClause));
        }
        public List<Person> getVotersStraightAssessment(int barangayID, int purokID, int clusterID)
        {
            string query = @"SELECT        Person.Fullname, Person.Precinct
FROM            (((Person LEFT OUTER JOIN
                         Barangay ON Barangay.ID = Person.Barangay) LEFT OUTER JOIN
                         Purok ON Purok.ID = Person.Purok) LEFT OUTER JOIN
                         Cluster ON Cluster.ID = Person.Cluster) ";

            string barangayID_ = barangayID != 0 ? " = " + barangayID.ToString() : "IS NULL";
            string purokID_ = purokID != 0 ? " = " + purokID.ToString() : "IS NULL";
            string clusterID_ = clusterID != 0 ? " = " + clusterID.ToString() : "IS NULL";


            string whereClause = $"WHERE (Barangay.ID {barangayID_}) AND (Purok.ID {purokID_}) AND (Cluster.ID {clusterID_})";
            whereClause += @" AND Person.Mayor = 'ATO' 
                              AND Person.Vice = 'ATO' 
                              AND Person.Councilor1 = 'ATO'
                              AND Person.Councilor2 = 'ATO'
                              AND Person.Councilor3 = 'ATO'
                              AND Person.Councilor4 = 'ATO'
                              AND Person.Councilor5 = 'ATO'
                              AND Person.Councilor6 = 'ATO'
                              AND Person.Councilor7 = 'ATO'
                              AND Person.Councilor8 = 'ATO'
";


            return Mapper.ConvertDataTable<Person>(this.ExecuteTabularQuery(query + whereClause));
        }
    }
}
