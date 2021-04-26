using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ResumeApi.Models
{
    public class Resume
    {

        Basic basic;
        public Basic Basic { get => basic; set => basic = value; }
        public List<Work> Works { get => works; set => works = value; }
        public List<Volunteer> Volunteers { get => volunteers; set => volunteers = value; }
        public List<Education> Educations { get => educations; set => educations = value; }
        public List<Award> Awards { get => awards; set => awards = value; }
        public List<Publication> Publications { get => publications; set => publications = value; }
        public List<Skill> Skills { get => skills; set => skills = value; }
        public List<Language> Languages { get => languages; set => languages = value; }
        public List<Interest> Interests { get => interests; set => interests = value; }
        public List<Reference> References { get => references; set => references = value; }

        public Resume(Basic basic) 
        {
            Basic = basic;
        }

        List<Work> works = new List<Work>();
        List<Volunteer> volunteers = new List<Volunteer>();
        List<Education> educations = new List<Education>();
        List<Award> awards = new List<Award>();
        List<Publication> publications = new List<Publication>();
        List<Skill> skills = new List<Skill>();
        List<Language> languages = new List<Language>();
        List<Interest> interests = new List<Interest>();
        List<Reference> references = new List<Reference>();


    }
}
