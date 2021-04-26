using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ResumeApi.Models
{
    public class Skill
    {
        string name;
        string level;
        
        public string Name { get => name; set => name = value; }
        public string Level { get => level; set => level = value; }
        public List<string> Keywords { get => keywords; set => keywords = value; }

        List<string> keywords = new List<string>();

        public Skill(string name, string level)
        {
            this.Name = name;
            this.Level = level;
        }
    }
}
