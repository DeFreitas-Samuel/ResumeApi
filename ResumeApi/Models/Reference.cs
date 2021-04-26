using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ResumeApi.Models
{
    public class Reference
    {
        string name;
        string reference;

        public string Name { get => name; set => name = value; }
        public string Referenc { get => reference; set => reference = value; }
    }
}
