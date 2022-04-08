using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Testapp.Helpers;

namespace Testapp.Models
{
    public class PieChartData 
    {
        int iD;

        public int ID
        {
            get { return iD; }
            set { iD = value; }
        }

        string barangayName;

        public string BarangayName
        {
            get { return barangayName; }
            set { barangayName = value; }
        }

        int ato;

        public int Ato
        {
            get { return ato; }
            set { ato = value; }
        }

        int dileAto;

        public int DileAto
        {
            get { return dileAto; }
            set { dileAto = value; }
        }

        int duhaDuha;

        public int DuhaDuha
        {
            get { return duhaDuha; }
            set { duhaDuha = value; }
        }
        int iNC;

        public int INC
        {
            get { return iNC; }
            set { iNC = value; }
        }
        int unassigned;

        public int Unassigned
        {
          get { return unassigned; }
          set { unassigned = value; }
        }

        
    }
}
