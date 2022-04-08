using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Testapp.Models;

namespace Testapp.Repository
{
    public class PersonRepository : DatabaseConnectPostgresql<Person>
    {
        public List<Person> listPersonByBarangayPurokCluster(int barangayID,int purokID, int clusterID)
        {
            string customQuery = "Select * from Person where Barangay = " + barangayID + " and Purok = " + purokID +" and Cluster = "+ clusterID + " ORDER BY ID";
            return this.getListCustomQuery(customQuery);
        }

        public List<Person> search(string filter)
        {
            string customQuery = "Select * from Person where Fullname like '%" + filter + "%'";
            return this.getListCustomQuery(customQuery);
        }
    }
}
