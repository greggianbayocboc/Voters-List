using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Testapp.Helpers;

namespace Testapp.Models
{
    public class PieChartData 
    {
       
        string barangayName;
        
        int ato;

        int dileAto;

        int duhaDuha;
        int iNC;

        public string BarangayName { get => barangayName; set => barangayName = value; }
        public int Ato { get => ato; set => ato = value; }
        public int DileAto { get => dileAto; set => dileAto = value; }
        public int DuhaDuha { get => duhaDuha; set => duhaDuha = value; }
        public int INC { get => iNC; set => iNC = value; }
    }
}
