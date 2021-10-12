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
        int person;
        int candidate;
        string assessment;
        int points;

        public int Survey { get => survey; set => survey = value; }
        public int Person { get => person; set => person = value; }
        public int Candidate { get => candidate; set => candidate = value; }
        public string Assessment { get => assessment; set => assessment = value; }
        public int Points { get => points; set => points = value; }
    }
}
