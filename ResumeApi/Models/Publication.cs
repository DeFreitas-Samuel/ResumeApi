using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ResumeApi.Models
{
    public class Publication
    {
        public Publication(string name,
                            string publisher, string releaseDate, 
                            string website, string summary)
        {
            this.Name = name;
            this.Publisher = publisher;
            this.ReleaseDate = releaseDate;
            this.Website = website;
            this.Summary = summary;
        }

        string name;
        string publisher;
        string releaseDate;
        string website;
        string summary;

        public string Name { get => name; set => name = value; }
        public string Publisher { get => publisher; set => publisher = value; }
        public string ReleaseDate { get => releaseDate; set => releaseDate = value; }
        public string Website { get => website; set => website = value; }
        public string Summary { get => summary; set => summary = value; }
    }
}
