using Entities.Core;
using Entities.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Entities.Models
{
    public class Exam : CoreEntity
    {
        [DataType(DataType.Date)]
        public DateTime CreatedDate { get; set; }

        public string Q1 { get; set; }
        public string Q1A { get; set; }
        public string Q1B { get; set; }
        public string Q1C { get; set; }
        public string Q1D { get; set; }
        public Answers Q1Correct { get; set; }

        public string Q2 { get; set; }
        public string Q2A { get; set; }
        public string Q2B { get; set; }
        public string Q2C { get; set; }
        public string Q2D { get; set; }
        public Answers Q2Correct { get; set; }

        public string Q3 { get; set; }
        public string Q3A { get; set; }
        public string Q3B { get; set; }
        public string Q3C { get; set; }
        public string Q3D { get; set; }
        public Answers Q3Correct { get; set; }

        public string Q4 { get; set; }
        public string Q4A { get; set; }
        public string Q4B { get; set; }
        public string Q4C { get; set; }
        public string Q4D { get; set; }
        public Answers Q4Correct { get; set; }
    }
}
