using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Testapp.Helpers;

namespace Testapp.Models
{
    public class Party : Model
    {
        string partyName;

        public string PartyName
        {
            get { return partyName; }
            set { partyName = value; }
        }

    }
}
