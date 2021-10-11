using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Testapp.Models;

namespace Testapp.Repository
{
    public class PurokRepository : DatabaseConnect<Purok>
    {
        public List<Purok> listPurokByBarangay(int barangayID)
        {
            string customQuery = "Select * from Purok where Barangay = "+barangayID+" ORDER BY ID";
            return this.getListCustomQuery(customQuery);
        }
    }
}
