using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Testapp.Helpers;

namespace Testapp.Models
{
    public class SurveyItem : Model
    {
        int survey;

        public int Survey
        {
            get { return survey; }
            set { survey = value; }
        }
        int person;

        public int Person
        {
            get { return person; }
            set { person = value; }
        }
        int candidate;

        public int Candidate
        {
            get { return candidate; }
            set { candidate = value; }
        }
        string assessment;

        public string Assessment
        {
            get { return assessment; }
            set { assessment = value; }
        }
        int points;

        public int Points
        {
            get { return points; }
            set { points = value; }
        }

    }
}
