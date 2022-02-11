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
                         ORDER BY Person.Fullname";
            return this.getListCustomQuery(query);
        }
    }
}
