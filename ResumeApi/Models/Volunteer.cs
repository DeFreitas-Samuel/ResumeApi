using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ResumeApi.Models
{
    public class Volunteer
    {
        public Volunteer(string organization, string position, string website, DateTime startDate, DateTime endDate, string summary)
        {
            this.Organization = organization;
            this.Position = position;
            this.Website = website;
            this.StartDate = startDate;
            this.EndDate = endDate;
            this.Summary = summary;
        }

        string organization;
        string position;
        string website;
        DateTime startDate;
        DateTime endDate;
        string summary;
        
        public string Organization { get => organization; set => organization = value; }
        public string Position { get => position; set => position = value; }
        public string Website { get => website; set => website = value; }
        public DateTime StartDate { get => startDate; set => startDate = value; }
        public DateTime EndDate { get => endDate; set => endDate = value; }
        public string Summary { get => summary; set => summary = value; }
        public List<string> Highlights { get => highlights; set => highlights = value; }

        List<string> highlights = new List<string>();
    }
}
