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

        public string PositionName
        {
            get { return positionName; }
            set { positionName = value; }
        }

        int positionOrder;

        public int PositionOrder
        {
            get { return positionOrder; }
            set { positionOrder = value; }
        }

    }
}
