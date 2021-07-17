using System;
using System.ComponentModel.DataAnnotations;


namespace MVC_ECD_Start.Models

   
{
    public class CollegeData
    {


        public int ID { get; set; }
        public string FederalSchoolCode { get; set; }
        public string SchoolName { get; set; }
        public string SchoolCity { get; set; }
        public string SchoolState { get; set; }
        public string SchoolURL { get; set; }
        public int  AverageAdmittedSATScores { get; set; }
        public int CumulativeACTMedianScore { get; set; }
        public string OverallAdmissionRate { get; set; }
        public string InStateTuitionCost { get; set; }
        public string OutStateTuitionCost { get; set; }
        public string EnrolledSttudentSize { get; set; }



    }


}




