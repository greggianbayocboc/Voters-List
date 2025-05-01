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
    public class LeaderPrintoutDtoRepository : DatabaseConnectPostgresql<LeaderPrintoutDto>
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
GROUP BY Barangay.BarangayName, Barangay.ID, Cluster.Leader, Purok.PurokName, Barangay.Coordinator, Purok.Leader, Cluster.ID, Purok.ID ORDER BY Barangay.BarangayName, Purok.purokname, CLUSTER.leader";
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


            string whereClause = "WHERE (Barangay.ID "+barangayID_+") AND (Purok.ID "+purokID_+") AND (Cluster.ID "+clusterID_+")";
            string orderClause = " ORDER By Person.fullname";

            return Mapper.ConvertDataTable<Person>(this.ExecuteTabularQuery(query + whereClause + orderClause));
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


            string whereClause = "WHERE (Barangay.ID " + barangayID_ + ") AND (Purok.ID " + purokID_ + ") AND (Cluster.ID " + clusterID_ + ")";
            whereClause += @" AND Person.Mayor = 'ONGIE-BERNALES-LIM' 
                              AND Person.Vice = 'MYRA FOSTANES- COLIS'
";


            return Mapper.ConvertDataTable<Person>(this.ExecuteTabularQuery(query + whereClause));
        }

        public List<Person> getVotersMayorAssessment(int barangayID, int purokID, int clusterID)
        {
            string query = @"SELECT        Person.Fullname, Person.Precinct
FROM            (((Person LEFT OUTER JOIN
                         Barangay ON Barangay.ID = Person.Barangay) LEFT OUTER JOIN
                         Purok ON Purok.ID = Person.Purok) LEFT OUTER JOIN
                         Cluster ON Cluster.ID = Person.Cluster) ";

            string barangayID_ = barangayID != 0 ? " = " + barangayID.ToString() : "IS NULL";
            string purokID_ = purokID != 0 ? " = " + purokID.ToString() : "IS NULL";
            string clusterID_ = clusterID != 0 ? " = " + clusterID.ToString() : "IS NULL";


            string whereClause = "WHERE (Barangay.ID " + barangayID_ + ") AND (Purok.ID " + purokID_ + ") AND (Cluster.ID " + clusterID_ + ")";
            whereClause += @" AND Person.Mayor = 'ONGIE-BERNALES-LIM' 
";

            return Mapper.ConvertDataTable<Person>(this.ExecuteTabularQuery(query + whereClause));
        }
        public List<Person> getVotersViceMayorAssessment(int barangayID, int purokID, int clusterID)
        {
            string query = @"SELECT        Person.Fullname, Person.Precinct
FROM            (((Person LEFT OUTER JOIN
                         Barangay ON Barangay.ID = Person.Barangay) LEFT OUTER JOIN
                         Purok ON Purok.ID = Person.Purok) LEFT OUTER JOIN
                         Cluster ON Cluster.ID = Person.Cluster) ";

            string barangayID_ = barangayID != 0 ? " = " + barangayID.ToString() : "IS NULL";
            string purokID_ = purokID != 0 ? " = " + purokID.ToString() : "IS NULL";
            string clusterID_ = clusterID != 0 ? " = " + clusterID.ToString() : "IS NULL";


            string whereClause = "WHERE (Barangay.ID " + barangayID_ + ") AND (Purok.ID " + purokID_ + ") AND (Cluster.ID " + clusterID_ + ")";
            whereClause += @"
                              AND Person.Vice = 'MYRA FOSTANES- COLIS'
";

            return Mapper.ConvertDataTable<Person>(this.ExecuteTabularQuery(query + whereClause));
        }



        public List<Person> getVotersWithSelection(int barangayID, int purokID, int clusterID, String selection, String candidate)
        {
            string query = @"SELECT        Person.Fullname, Person.Precinct
FROM            (((Person LEFT OUTER JOIN
                         Barangay ON Barangay.ID = Person.Barangay) LEFT OUTER JOIN
                         Purok ON Purok.ID = Person.Purok) LEFT OUTER JOIN
                         Cluster ON Cluster.ID = Person.Cluster) ";

            string barangayID_ = barangayID != 0 ? " = " + barangayID.ToString() : "IS NULL";
            string purokID_ = purokID != 0 ? " = " + purokID.ToString() : "IS NULL";
            string clusterID_ = clusterID != 0 ? " = " + clusterID.ToString() : "IS NULL";


            string whereClause = "WHERE (Barangay.ID " + barangayID_ + ") AND (Purok.ID " + purokID_ + ") AND (Cluster.ID " + clusterID_ + ")";
            if (candidate != "UNASSIGNED")
            {
                whereClause += @" AND Person." + selection + " = '" + candidate + "'";
            }
            else
            {
                whereClause += @" AND Person." + selection + " is null";
            }

            return Mapper.ConvertDataTable<Person>(this.ExecuteTabularQuery(query + whereClause));
        }
    }
}
