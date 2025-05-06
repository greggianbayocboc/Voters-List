using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Testapp.Models;

namespace Testapp.Repository
{
    public class PersonDtoRepository : DatabaseConnectPostgresql<PersonDto>
    {
        public List<PersonDto> getPrintableVotersAll()
        {
            string query = @"SELECT Person.Fullname, Barangay.BarangayName AS Barangay, Cluster.Leader AS Cluster, Purok.PurokName AS Purok, Person.Precinct
                         FROM (((Person LEFT OUTER JOIN
                         Barangay ON Barangay.ID = Person.Barangay) LEFT OUTER JOIN
                         Purok ON Purok.ID = Person.Purok) LEFT OUTER JOIN
                         Cluster ON Cluster.ID = Person.Cluster) 
                         ORDER BY barangayname, person.fullname";
            return this.getListCustomQuery(query);
        }

        public List<PersonDto> getPrintableVoters(int barangayID, int purokID, int clusterID)
        {
            string query = @"SELECT Person.Fullname, Barangay.BarangayName AS Barangay, Cluster.Leader AS Cluster, Purok.PurokName AS Purok, Person.Precinct
                         FROM (((Person LEFT OUTER JOIN
                         Barangay ON Barangay.ID = Person.Barangay) LEFT OUTER JOIN
                         Purok ON Purok.ID = Person.Purok) LEFT OUTER JOIN
                         Cluster ON Cluster.ID = Person.Cluster) ";


            string barangayID_ = barangayID != 0 ? " = " + barangayID.ToString() : "= Barangay.ID";
            string purokID_ = purokID != 0 ? " = " + purokID.ToString() : "= Purok.ID";
            string clusterID_ = clusterID != 0 ? " = " + clusterID.ToString() : "= Cluster.ID";

            string whereClause = "WHERE (Barangay.ID " + barangayID_ + ") AND (Purok.ID " + purokID_ + ") AND (Cluster.ID " + clusterID_ + ")";
            string orderByClause = " ORDER BY barangayname, person.fullname";
            return this.getListCustomQuery(query + whereClause + orderByClause);
        }

        public List<PersonDto> getPrintableVotersMayor(int barangayID, int purokID, int clusterID, string mayor)
        {
            string query = @"SELECT Person.Fullname, Barangay.BarangayName AS Barangay, Cluster.Leader AS Cluster, Purok.PurokName AS Purok, Person.Precinct
                         FROM (((Person LEFT OUTER JOIN
                         Barangay ON Barangay.ID = Person.Barangay) LEFT OUTER JOIN
                         Purok ON Purok.ID = Person.Purok) LEFT OUTER JOIN
                         Cluster ON Cluster.ID = Person.Cluster) ";


            string barangayID_ = barangayID != 0 ? " = " + barangayID.ToString() : "= Barangay.ID";
            string purokID_ = purokID != 0 ? " = " + purokID.ToString() : "= Purok.ID";
            string clusterID_ = clusterID != 0 ? " = " + clusterID.ToString() : "= Cluster.ID";

            string whereClause = "WHERE (Barangay.ID " + barangayID_ + ") AND (Purok.ID " + purokID_ + ") AND (Cluster.ID " + clusterID_ + ") AND (Person.mayor = '" + mayor + "')";
            string orderByClause = " ORDER BY barangayname, person.fullname";
            return this.getListCustomQuery(query + whereClause + orderByClause);
        }

        public List<PersonDto> getPrintableVotersVice(int barangayID, int purokID, int clusterID, string vice)
        {
            string query = @"SELECT Person.Fullname, Barangay.BarangayName AS Barangay, Cluster.Leader AS Cluster, Purok.PurokName AS Purok, Person.Precinct
                         FROM (((Person LEFT OUTER JOIN
                         Barangay ON Barangay.ID = Person.Barangay) LEFT OUTER JOIN
                         Purok ON Purok.ID = Person.Purok) LEFT OUTER JOIN
                         Cluster ON Cluster.ID = Person.Cluster) ";


            string barangayID_ = barangayID != 0 ? " = " + barangayID.ToString() : "= Barangay.ID";
            string purokID_ = purokID != 0 ? " = " + purokID.ToString() : "= Purok.ID";
            string clusterID_ = clusterID != 0 ? " = " + clusterID.ToString() : "= Cluster.ID";

            string whereClause = "WHERE (Barangay.ID " + barangayID_ + ") AND (Purok.ID " + purokID_ + ") AND (Cluster.ID " + clusterID_ + ") AND (Person.vice = '" + vice + "')";
            string orderByClause = " ORDER BY barangayname, person.fullname";
            return this.getListCustomQuery(query + whereClause + orderByClause);
        }


        public List<PersonDto> getPrintableVotersStraight(int barangayID, int purokID, int clusterID, string vice)
        {
            string query = @"SELECT Person.Fullname, Barangay.BarangayName AS Barangay, Cluster.Leader AS Cluster, Purok.PurokName AS Purok, Person.Precinct
                         FROM (((Person LEFT OUTER JOIN
                         Barangay ON Barangay.ID = Person.Barangay) LEFT OUTER JOIN
                         Purok ON Purok.ID = Person.Purok) LEFT OUTER JOIN
                         Cluster ON Cluster.ID = Person.Cluster) ";


            string barangayID_ = barangayID != 0 ? " = " + barangayID.ToString() : "= Barangay.ID";
            string purokID_ = purokID != 0 ? " = " + purokID.ToString() : "= Purok.ID";
            string clusterID_ = clusterID != 0 ? " = " + clusterID.ToString() : "= Cluster.ID";

            string whereClause = "WHERE (Barangay.ID " + barangayID_ + ") AND (Purok.ID " + purokID_ + ") AND (Cluster.ID " + clusterID_ + ") AND (Person.vice = 'MYRA FOSTANES- COLIS' AND Person.mayor = 'ONGIE-BERNALES-LIM')";
            string orderByClause = " ORDER BY barangayname, person.fullname";
            return this.getListCustomQuery(query + whereClause + orderByClause);
        }
    }
}
