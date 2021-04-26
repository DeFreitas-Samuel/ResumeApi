using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ResumeApi.Models
{
    public class Award
    {
        public Award(string title, DateTime date, string awarder, string summary)
        {
            this.Title = title;
            this.Date = date;
            this.Awarder = awarder;
            this.Summary = summary;
        }

        string title;
        DateTime date;
        string awarder;
        string summary;

        public string Title { get => title; set => title = value; }
        public DateTime Date { get => date; set => date = value; }
        public string Awarder { get => awarder; set => awarder = value; }
        public string Summary { get => summary; set => summary = value; }
    }
}
