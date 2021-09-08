using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Testapp.Models;

namespace Testapp.Repository
{
    public class BarangayRepository : DatabaseConnect<Barangay>
    {
        PurokRepository purokRepository = new PurokRepository();
        ClusterRepository clusterRepository = new ClusterRepository();
        public bool removeBarangay(int barangayId)
        {
            List<Purok> purokList = purokRepository.listPurokByBarangay(barangayId);
            foreach(Purok purok in purokList)
            {
                List<Cluster> clusterList = clusterRepository.listClusterByPurok(purok.ID);
                foreach (Cluster cluster in clusterList)
                {
                    clusterRepository.Delete(cluster);
                }
                purokRepository.Delete(purok);
            }
            this.Delete(this.getOne(barangayId));
            return true;
        }
    }
}
