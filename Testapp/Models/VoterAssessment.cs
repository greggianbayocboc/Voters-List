using gregg.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Testapp.Helpers;

namespace Testapp.Models
{
    public class VoterAssessment : Model
    {
        private int voter;
        private string voterName;
        AssessmentOption mayor;
        AssessmentOption vice;
        AssessmentOption councilor1;
        AssessmentOption councilor2;
        AssessmentOption councilor3;
        AssessmentOption councilor4;
        AssessmentOption councilor5;
        AssessmentOption councilor6;
        AssessmentOption councilor7;
        AssessmentOption councilor8;

        public int Voter { get => voter; set => voter = value; }
        public string VoterName { get => voterName; set => voterName = value; }
        internal AssessmentOption Mayor { get => mayor; set => mayor = value; }
        internal AssessmentOption Vice { get => vice; set => vice = value; }
        internal AssessmentOption Councilor1 { get => councilor1; set => councilor1 = value; }
        internal AssessmentOption Councilor2 { get => councilor2; set => councilor2 = value; }
        internal AssessmentOption Councilor3 { get => councilor3; set => councilor3 = value; }
        internal AssessmentOption Councilor4 { get => councilor4; set => councilor4 = value; }
        internal AssessmentOption Councilor5 { get => councilor5; set => councilor5 = value; }
        internal AssessmentOption Councilor6 { get => councilor6; set => councilor6 = value; }
        internal AssessmentOption Councilor7 { get => councilor7; set => councilor7 = value; }
        internal AssessmentOption Councilor8 { get => councilor8; set => councilor8 = value; }
    }
}
