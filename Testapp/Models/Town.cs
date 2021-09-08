using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Testapp.Helpers;

namespace Testapp.Models
{
    public class Town : Model
    {
        private String townName;

        public String TownName
        {
            get { return townName; }
            set { townName = value; }
        }

        
    }
}
