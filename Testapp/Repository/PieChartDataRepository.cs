using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Testapp.Models;

namespace Testapp.Repository
{
    public class PieChartDataRepository : DatabaseConnect<PieChartData>
    {
        public List<PieChartData> generateData(string position)
        {
            List<PieChartData> chartsData = new List<PieChartData>();
            string query = "";
                switch (position)
                {
                    case "MAYOR":
                            query = @"SELECT  BarangayName,       
                            (SELECT count(*) from Person where Person.Barangay = Barangay.ID and Person.Mayor = 'ATO') as Ato,
                            (SELECT count(*) from Person where Person.Barangay = Barangay.ID and Person.Mayor = 'DILE ATO') AS DileAto, 
                            (SELECT count(*) from Person where Person.Barangay = Barangay.ID and Person.Mayor = 'DUHA DUHA') as DuhaDuha, 
                            (SELECT count(*) from Person where Person.Barangay = Barangay.ID and Person.Mayor = 'INC') as INC
                            FROM Barangay order by BarangayName desc";
                        
                        break;
                    case "VICE-MAYOR":
                        query = @"SELECT    BarangayName,     
                        (SELECT count(*) from Person where Person.Barangay = Barangay.ID and Person.Vice = 'ATO') as Ato,
                        (SELECT count(*) from Person where Person.Barangay = Barangay.ID and Person.Vice = 'DILE ATO') AS DileAto, 
                        (SELECT count(*) from Person where Person.Barangay = Barangay.ID and Person.Vice = 'DUHA DUHA') as DuhaDuha, 
                        (SELECT count(*) from Person where Person.Barangay = Barangay.ID and Person.Vice = 'INC') as INC
                        FROM Barangay order by BarangayName desc";
                        break;
                    default:
                        break;
                }
            return this.getListCustomQuery(query);
            
           
        }
    }
}
