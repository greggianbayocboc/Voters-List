using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Testapp.Helpers;

namespace Testapp.Models
{
    public class Candidate : Model
    {
       
       
        string fullname;

        public string Fullname
        {
            get { return fullname; }
            set { fullname = value; }
        }

        string position_;

        public string Position_
        {
            get { return position_; }
            set { position_ = value; }
        }

        string party;

        public string Party
        {
            get { return party; }
            set { party = value; }
        }
    }
}
