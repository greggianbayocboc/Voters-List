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

        public string Position_ { get => position_; set => position_ = value; }
        public string Party { get => party; set => party = value; }

        string position_;

        string party;
    }
}
