using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Testapp.Helpers;

namespace Testapp.Models
{
    public class Position : Model
    {
       
        string positionName;

        int positionOrder;

        public string PositionName { get => positionName; set => positionName = value; }
        public int PositionOrder { get => positionOrder; set => positionOrder = value; }
    }
}
