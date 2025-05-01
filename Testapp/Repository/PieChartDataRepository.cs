using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Testapp.Models;

namespace Testapp.Repository
{
    public class PieChartDataRepository : DatabaseConnectPostgresql<PieChartData>
    {
        public List<PieChartData> generateData(string position)
        {
            List<PieChartData> chartsData = new List<PieChartData>();
            string query = "";
                switch (position)
                {
                    case "MAYOR":
                            query = @"SELECT  ID, BarangayName,       
                            (SELECT count(*) from Person where Person.Barangay = Barangay.ID and Person.Mayor = 'ONGIE-BERNALES-LIM') as Ato,
                            (SELECT count(*) from Person where Person.Barangay = Barangay.ID and Person.Mayor = 'JUN JAYOMA') AS DileAto, 
                            (SELECT count(*) from Person where Person.Barangay = Barangay.ID and Person.Mayor = 'DUHA-DUHA') as DuhaDuha, 
                            (SELECT count(*) from Person where Person.Barangay = Barangay.ID and Person.Mayor IS null) as Unassigned
                            FROM Barangay order by BarangayName ";
                        
                        break;
                    case "VICE-MAYOR":
                        query = @"SELECT    ID, BarangayName,     
                        (SELECT count(*) from Person where Person.Barangay = Barangay.ID and Person.Vice = 'MYRA FOSTANES- COLIS') as Ato,
                        (SELECT count(*) from Person where Person.Barangay = Barangay.ID and Person.Vice = 'HELEN JAYOMA') AS DileAto, 
                        (SELECT count(*) from Person where Person.Barangay = Barangay.ID and Person.Vice = 'DUHA-DUHA') as DuhaDuha, 
                        (SELECT count(*) from Person where Person.Barangay = Barangay.ID and Person.Vice IS null) as Unassigned
                        FROM Barangay order by BarangayName ";
                        break;
                    default:
                        break;
                }
            return this.getListCustomQuery(query);
            
           
        }
    }
}
