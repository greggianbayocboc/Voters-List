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


            string barangayID_ = barangayID != 0 ? " = " + barangayID.ToString() : "IS NULL";
            string purokID_ = purokID != 0 ? " = " + purokID.ToString() : "IS NULL";
            string clusterID_ = clusterID != 0 ? " = " + clusterID.ToString() : "IS NULL";

            string whereClause = "WHERE (Barangay.ID " + barangayID_ + ") AND (Purok.ID " + purokID_ + ") AND (Cluster.ID " + clusterID_ + ")";
            string orderByClause = " ORDER BY barangayname, person.fullname";
            return this.getListCustomQuery(query + whereClause + orderByClause);
        }
    }
}
