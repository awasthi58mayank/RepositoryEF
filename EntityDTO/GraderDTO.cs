﻿
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityDTO
{
    public class GraderDTO
    {
        public int Marks_Obtained { get; set; }
        public string Feedback { get; set; }
        public string BatchID { get; set; }
        public string CourseID { get; set; }
        public int ParticipantID { get; set; }

    }
}

