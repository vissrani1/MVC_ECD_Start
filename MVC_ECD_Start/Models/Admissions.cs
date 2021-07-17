using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MVC_ECD_Start.Models
{
    public class Admissions
    {
        public int AdmissionsKey { get; set; }
        public int AverageAdmittedSATScored { get; set; }
        public int CumulativeACTMedianScore { get; set; }
        public string OverallAdmissionRate { get; set; }
        public int ID { get; set; }
    }
}
