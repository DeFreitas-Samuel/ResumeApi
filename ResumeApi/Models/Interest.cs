using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ResumeApi.Models
{
    public class Interest
    {
        string name; 
        
        public string Name { get => name; set => name = value; }
        public List<string> Keywords { get => keywords; set => keywords = value; }

        List<string> keywords = new List<string>();
    }
}
