using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ResumeApi.Models
{
    public class Education
    {
        string institution;
        string area;
        string studytype;
        DateTime startDate;
        DateTime endDate;
        string gpa;
      
        public string Institution { get => institution; set => institution = value; }
        public string Area { get => area; set => area = value; }
        public string Studytype { get => studytype; set => studytype = value; }
        public DateTime StartDate { get => startDate; set => startDate = value; }
        public DateTime EndDate { get => endDate; set => endDate = value; }
        public string Gpa { get => gpa; set => gpa = value; }
        public List<string> Courses { get => courses; set => courses = value; }

        List<string> courses = new List<string>();

        public Education(string institution, string area, string studytype, DateTime startDate, DateTime endDate, string gpa)
        {
            this.Institution = institution;
            this.Area = area;
            this.Studytype = studytype;
            this.StartDate = startDate;
            this.EndDate = endDate;
            this.Gpa = gpa;
        }
    }
}
