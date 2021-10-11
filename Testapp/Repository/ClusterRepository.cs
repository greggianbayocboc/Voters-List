using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Testapp.Models;

namespace Testapp.Repository
{
    public class ClusterRepository : DatabaseConnect<Cluster>
    {
        public List<Cluster> listClusterByPurok(int purokID)
        {
            string customQuery = "Select * from Cluster where Purok = " + purokID;
            return this.getListCustomQuery(customQuery);
        }
    }
}
