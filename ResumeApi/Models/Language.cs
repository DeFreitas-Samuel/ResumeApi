using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ResumeApi.Models
{
    public class Language
    {
        public Language(string language, string fluency)
        {
            this.Languag = language;
            this.Fluency = fluency;
        }

        string language;
        string fluency;

        public string Languag { get => language; set => language = value; }
        public string Fluency { get => fluency; set => fluency = value; }
    }
}
