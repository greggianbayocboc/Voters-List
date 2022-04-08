using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gregg.Helpers
{
    class Utils
    {
        public static string generateWhereClauseForLeaders(int? barangayId, int? purokId, int? clusterId)
        {
            string filter = string.Empty;
            if (barangayId != -1)
            {
                filter += "Barangay.ID = " + barangayId;
            }
            if (purokId != -1)
            {
                if (filter != string.Empty)
                {
                    filter += " AND Purok.ID = " + purokId;
                }
                else
                {
                    filter += "Purok.ID = " + purokId;
                }
            }
            if (clusterId != -1)
            {
                if (filter != string.Empty)
                {
                    filter += " AND Cluster.ID = " + clusterId;
                }
                else
                {
                    filter += "Cluster.ID = " + clusterId;
                }
            }
            if (filter != string.Empty)
            {
                filter = "WHERE " + filter;
            }
            return filter;
        }

    }
}
