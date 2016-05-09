using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grade_Predictor.Models
{
    public class OutputGrade
    {
        // Remaining grades
        public int Homework { get; set; }
        public int Sb_Hw { get; set; }
        public int Quiz { get; set; }
        public int Sb_Qz { get; set; }
        public int Midterm { get; set; }
        public int Sb_Mdt { get; set; }
        public int Final { get; set; }
    }
}
