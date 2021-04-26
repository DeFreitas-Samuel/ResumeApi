using Microsoft.AspNetCore.Mvc;
using ResumeApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace ResumeApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class resume : ControllerBase
    {
        static Basic basic = new Basic("Samuel", "Ing. Soft", "1.jpg", "s@gmial.com", "8095554433", "www.samuel.com", "Buen empleado",
                                "Calle D", "1074", "Santo Domingo", "DR", "Caribbean", "twitter", "Samuel123", "twitter.com/Samuel123");
        
        static List < Language > languages = new List<Language>() { new Language("Espanol", "Nativo") };
        static Resume initialResume = new Resume(basic, languages);
        static int version = 1;

        #region  GetMethodsRegion

        [HttpHead]
        [HttpGet]
        public ActionResult<Resume> Get()
        {
            return initialResume;
        }

        [HttpHead("basics")]
        [HttpGet("basics")]
        public ActionResult<Basic> GetBasic()
        {
            return initialResume.Basic;
        }

        [HttpHead("basics/location")]
        [HttpGet("basics/location")]
        public ActionResult<Location> GetLocation()
        {
            return initialResume.Basic.Location;
        }

        [HttpHead("basics/profiles")]
        [HttpGet("basics/profiles")]
        public ActionResult<List<Profile>> GetProfile()
        {
            return initialResume.Basic.Profiles;
        }

        [HttpHead("basics/profiles/{network}")]
        [HttpGet("basics/profiles/{network}")]
        public ActionResult<Profile> GetProfile(string network)
        {
            var filter = initialResume.Basic.Profiles.Find(e => e.Network == network);
            if (filter != null)
            {
                return filter;
            }
            else 
            {
                return NotFound("A profile in that network was not found");
            }
            
        }

        [HttpHead("works")]
        [HttpGet("works")]
        public ActionResult<List<Work>> GetWork()
        {
            return initialResume.Works;
        }

        [HttpHead("works/{company}")]
        [HttpGet("works/{company}")]
        public ActionResult<Work> GetWork(string company)
        {
            var filter = initialResume.Works.Find(e => e.Company == company);
            if (filter != null)
            {
                return filter;
            }
            else
            {
                return NotFound("A job in that company was not found");
            }

        }

        [HttpHead("volunteers")]
        [HttpGet("volunteers")]
        public ActionResult<List<Volunteer>> GetVolunteer()
        {
            return initialResume.Volunteers;
        }

        [HttpHead("volunteers/{organization}")]
        [HttpGet("volunteers/{organization}")]
        public ActionResult<Volunteer> GetVolunteer(string organization)
        {
            var filter = initialResume.Volunteers.Find(e => e.Organization == organization);
            if (filter != null)
            {
                return filter;
            }
            else
            {
                return NotFound("A voluntary job in that organization was not found");
            }

        }

        [HttpHead("education")]
        [HttpGet("education")]
        public ActionResult<List<Education>> GetEducation()
        {
            return initialResume.Educations;
        }


        [HttpHead("education/{institution}")]
        [HttpGet("education/{institution}")]
        public ActionResult<Education> GetEducation(string institution)
        {
            var filter = initialResume.Educations.Find(e => e.Institution == institution);
            if (filter != null)
            {
                return filter;
            }
            else
            {
                return NotFound("A degree in that institution was not found");
            }

        }


        [HttpHead("awards")]
        [HttpGet("awards")]
        public ActionResult<List<Award>> GetAwards()
        {
            return initialResume.Awards;
        }

        [HttpHead("awards/{title}")]
        [HttpGet("awards/{title}")]
        public ActionResult<Award> GetAwards(string title)
        {
            var filter = initialResume.Awards.Find(e => e.Title == title);
            if (filter != null)
            {
                return filter;
            }
            else
            {
                return NotFound("A award with that title was not found");
            }

        }

        [HttpHead("publications")]
        [HttpGet("publications")]
        public ActionResult<List<Publication>> GetPublications()
        {
            return initialResume.Publications;
        }

        [HttpHead("publications/{name}")]
        [HttpGet("publications/{name}")]
        public ActionResult<Publication> GetPublications(string name)
        {
            var filter = initialResume.Publications.Find(e => e.Name == name);
            if (filter != null)
            {
                return filter;
            }
            else
            {
                return NotFound("A publication with that name was not found");
            }

        }

        [HttpHead("skills")]
        [HttpGet("skills")]
        public ActionResult<List<Skill>> GetSkills()
        {
            return initialResume.Skills;
        }

        [HttpHead("skills/{name}")]
        [HttpGet("skills/{name}")]
        public ActionResult<Skill> GetSkills(string name)
        {
            var filter = initialResume.Skills.Find(e => e.Name == name);
            if (filter != null)
            {
                return filter;
            }
            else
            {
                return NotFound("A skill with that name was not found");
            }

        }

        [HttpHead("languages")]
        [HttpGet("languages")]
        public ActionResult<List<Language>> GetLanguages()
        {
            return initialResume.Languages;
        }

        [HttpHead("languages/{language}")]
        [HttpGet("languages/{language}")]
        public ActionResult<Language> GetLanguages(string language)
        {
            var filter = initialResume.Languages.Find(e => e.Languag == language);
            if (filter != null)
            {
                return filter;
            }
            else
            {
                return NotFound("A skill with that name was not found");
            }

        }

        [HttpHead("interests")]
        [HttpGet("interests")]
        public ActionResult<List<Interest>> GetInterest()
        {

            return initialResume.Interests;
        }

        [HttpHead("interests/{name}")]
        [HttpGet("interests/{name}")]
        public ActionResult<Interest> GetInterest(string name)
        {
            var filter = initialResume.Interests.Find(e => e.Name == name);
            if (filter != null)
            {
                return filter;
            }
            else
            {
                return NotFound("A Interest with that name was not found");
            }

        }

        [HttpHead("references")]
        [HttpGet("references")]
        public ActionResult<List<Reference>> GetReference()
        {
            return initialResume.References;
        }

        [HttpHead("references/{name}")]
        [HttpGet("references/{name}")]
        public ActionResult<Reference> GetReference(string name)
        {
            var filter = initialResume.References.Find(e => e.Name == name);
            if (filter != null)
            {
                return filter;
            }
            else
            {
                return NotFound("A Reference with that name was not found");
            }

        }

        #endregion

        #region PostMethodsRegion
        [BasicAuthorization]
        [HttpPost("basics/profiles")]
        public ActionResult<Profile> Post([FromBody] Profile profile)
        {
            var filter = initialResume.Basic.Profiles.Find(e => e.Network == profile.Network);
            if (filter != null)
            {
                return Conflict("You can't have two profiles in the same network");
            }
            else
            {
                initialResume.Basic.Profiles.Add(profile);
                return Created("basics/profiles/" + profile.Network, profile);
            }

        }
        [BasicAuthorization]
        [HttpPost("works")]
        public ActionResult<Profile> Post([FromBody] Work work)
        {
            var filter = initialResume.Works.Find(e => e.Company == work.Company);
            if (filter != null)
            {
                return Conflict("You can't have two positions in the same company");
            }
            else
            {
                initialResume.Works.Add(work);
                return Created("works/" + work.Company, work);
            }

        }
        [BasicAuthorization]
        [HttpPost("volunteers")]
        public ActionResult<Profile> Post([FromBody] Volunteer volunteer)
        {
            var filter = initialResume.Volunteers.Find(e => e.Organization == volunteer.Organization);
            if (filter != null)
            {
                return Conflict("You can't have two positions in the same organization");
            }
            else
            {
                initialResume.Volunteers.Add(volunteer);
                return Created("volunteers/" + volunteer.Organization, volunteer);
            }

        }
        [BasicAuthorization]
        [HttpPost("education")]
        public ActionResult<Profile> Post([FromBody] Education education)
        {
            var filter = initialResume.Educations.Find(e => e.Institution == education.Institution);
            if (filter != null)
            {
                return Conflict("Duplicates are not allowed");
            }
            else
            {
                initialResume.Educations.Add(education);
                return Created("education/" + education.Institution, education);
            }

        }
        [BasicAuthorization]
        [HttpPost("awards")]
        public ActionResult<Profile> Post([FromBody] Award award)
        {
            var filter = initialResume.Awards.Find(e => e.Title == award.Title);
            if (filter != null)
            {
                return Conflict("Duplicates are not allowed");
            }
            else
            {
                initialResume.Awards.Add(award);
                return Created("awards/" + award.Title, award);
            }

        }
        [BasicAuthorization]
        [HttpPost("publications")]
        public ActionResult<Profile> Post([FromBody] Publication publication)
        {
            var filter = initialResume.Publications.Find(e => e.Name == publication.Name);
            if (filter != null)
            {
                return Conflict("Duplicates are not allowed");
            }
            else
            {
                initialResume.Publications.Add(publication);
                return Created("awards/" + publication.Name, publication);
            }

        }
        [BasicAuthorization]
        [HttpPost("skills")]
        public ActionResult<Profile> Post([FromBody] Skill skill)
        {
            var filter = initialResume.Publications.Find(e => e.Name == skill.Name);
            if (filter != null)
            {
                return Conflict("Duplicates are not allowed");
            }
            else
            {
                initialResume.Skills.Add(skill);
                return Created("awards/" + skill.Name, skill);
            }

        }
        [BasicAuthorization]
        [HttpPost("languages")]
        public ActionResult<Profile> Post([FromBody] Language language)
        {
            var filter = initialResume.Languages.Find(e => e.Languag  == language.Languag);
            if (filter != null)
            {
                return Conflict("Duplicates are not allowed");
            }
            else
            {
                initialResume.Languages.Add(language);
                return Created("languages/" + language.Languag, language);
            }

        }
        [BasicAuthorization]
        [HttpPost("interests")]
        public ActionResult<Profile> Post([FromBody] Interest interest)
        {
            var filter = initialResume.Interests.Find(e => e.Name == interest.Name);
            if (filter != null)
            {
                return Conflict("Duplicates are not allowed");
            }
            else
            {
                initialResume.Interests.Add(interest);
                return Created("languages/" + interest.Name, interest);
            }

        }

        [BasicAuthorization]
        [HttpPost("references")]
        public ActionResult<Profile> Post([FromBody] Reference reference)
        {
            var filter = initialResume.References.Find(e => e.Name == reference.Name);
            if (filter != null)
            {
                return Conflict("Duplicates are not allowed");
            }
            else
            {
                initialResume.References.Add(reference);
                return Created("languages/" + reference.Name, reference);
            }

        }
        #endregion

        #region PutMethodsRegion
        
        [BasicAuthorization]
        [HttpPut("basics/profiles/{network}")]
        public ActionResult<Profile> Put(string network, [FromBody] Profile profile)
        {
            var filter = initialResume.Basic.Profiles.Find(e => e.Network == network);
            if (filter != null)
            {
                int index = initialResume.Basic.Profiles.FindIndex(0, e => e == filter);
                initialResume.Basic.Profiles[index] = profile;
                return NoContent();
            }
            else
            {
                return NotFound("Put target not found");
            }

        }

        [BasicAuthorization]
        [HttpPut("works/{company}")]
        public ActionResult<Profile> Put(string company, [FromBody] Work work)
        {
            var filter = initialResume.Works.Find(e => e.Company == company);
            if (filter != null)
            {
                int index = initialResume.Works.FindIndex(0, e => e == filter);
                initialResume.Works[index] = work;
                return NoContent();
            }
            else
            {
                return NotFound("Put target not found");
            }

        }

        [BasicAuthorization]
        [HttpPut("volunteers/{organization}")]
        public ActionResult<Profile> Put(string organization, [FromBody] Volunteer volunteer)
        {
            var filter = initialResume.Volunteers.Find(e => e.Organization == organization);
            if (filter != null)
            {
                int index = initialResume.Volunteers.FindIndex(0, e => e == filter);
                initialResume.Volunteers[index] = volunteer;
                return NoContent();
            }
            else
            {
                return NotFound("Put target not found");
            }

        }

        [BasicAuthorization]
        [HttpPut("education/{institution}")]
        public ActionResult<Profile> Put(string institution, [FromBody] Education education)
        {
            var filter = initialResume.Educations.Find(e => e.Institution == institution);
            if (filter != null)
            {
                int index = initialResume.Educations.FindIndex(0, e => e == filter);
                initialResume.Educations[index] = education;
                return NoContent();
            }
            else
            {
                return NotFound("Put target not found");
            }

        }

        [BasicAuthorization]
        [HttpPut("awards/{title}")]
        public ActionResult<Profile> Put(string title, [FromBody] Award award)
        {
            var filter = initialResume.Awards.Find(e => e.Title == title);
            if (filter != null)
            {
                int index = initialResume.Awards.FindIndex(0, e => e == filter);
                initialResume.Awards[index] = award;
                return NoContent();
            }
            else
            {
                return NotFound("Put target not found");
            }

        }

        [BasicAuthorization]
        [HttpPut("publications/{title}")]
        public ActionResult<Profile> Put(string name, [FromBody] Publication publication)
        {
            var filter = initialResume.Publications.Find(e => e.Name == name);
            if (filter != null)
            {
                int index = initialResume.Publications.FindIndex(0, e => e == filter);
                initialResume.Publications[index] = publication;
                return NoContent();
            }
            else
            {
                return NotFound("Put target not found");
            }

        }

        [BasicAuthorization]
        [HttpPut("skills/{name}")]
        public ActionResult<Profile> Put(string name, [FromBody] Skill skill)
        {
            var filter = initialResume.Skills.Find(e => e.Name == name);
            if (filter != null)
            {
                int index = initialResume.Skills.FindIndex(0, e => e == filter);
                initialResume.Skills[index] = skill;
                return NoContent();
            }
            else
            {
                return NotFound("Put target not found");
            }

        }


        [BasicAuthorization]
        [HttpPut("languages/{language}")]
        public ActionResult<Profile> Put(string languag, [FromBody] Language language)
        {
            var filter = initialResume.Languages.Find(e => e.Languag == languag);
            if (filter != null)
            {
                int index = initialResume.Languages.FindIndex(0, e => e == filter);
                initialResume.Languages[index] = language;
                return NoContent();
            }
            else
            {
                return NotFound("Put target not found");
            }

        }

        [BasicAuthorization]
        [HttpPut("interests/{name}")]
        public ActionResult<Profile> Put(string name, [FromBody] Interest interest)
        {
            var filter = initialResume.Interests.Find(e => e.Name == name);
            if (filter != null)
            {
                int index = initialResume.Interests.FindIndex(0, e => e == filter);
                initialResume.Interests[index] = interest;
                return NoContent();
            }
            else
            {
                return NotFound("Put target not found");
            }

        }

        [BasicAuthorization]
        [HttpPut("references/{name}")]
        public ActionResult<Profile> Put(string name, [FromBody] Reference reference)
        {
            var filter = initialResume.References.Find(e => e.Name == name);
            if (filter != null)
            {
                int index = initialResume.References.FindIndex(0, e => e == filter);
                initialResume.References[index] = reference;
                return NoContent();
            }
            else
            {
                return NotFound("Put target not found");
            }

        }
        #endregion

        #region DeleteMethodsRegion
        [BasicAuthorization]
        [HttpDelete("basics/profiles/{network}")]
        public ActionResult<Profile> DeleteProfile(string network)
        {
            var filter = initialResume.Basic.Profiles.Find(e => e.Network == network);
            if (filter != null)
            {
                int index = initialResume.Basic.Profiles.FindIndex(0, e => e == filter);
                initialResume.Basic.Profiles.RemoveAt(index);
                return NoContent();
            }
            else
            {
                return NotFound("Delete target not found");
            }

        }

        [BasicAuthorization]
        [HttpDelete("works/{company}")]
        public ActionResult<Profile> DeleteWork(string company)
        {
            var filter = initialResume.Works.Find(e => e.Company == company);
            if (filter != null)
            {
                int index = initialResume.Works.FindIndex(0, e => e == filter);
                initialResume.Works.RemoveAt(index);
                return NoContent();
            }
            else
            {
                return NotFound("Delete target not found");
            }

        }

        [BasicAuthorization]
        [HttpDelete("volunteer/{organization}")]
        public ActionResult<Profile> DeleteVolunteer(string organization)
        {
            var filter = initialResume.Volunteers.Find(e => e.Organization == organization);
            if (filter != null)
            {
                int index = initialResume.Volunteers.FindIndex(0, e => e == filter);
                initialResume.Volunteers.RemoveAt(index);
                return NoContent();
            }
            else
            {
                return NotFound("Delete target not found");
            }

        }


        [BasicAuthorization]
        [HttpDelete("education/{institution}")]
        public ActionResult<Profile> DeleteEducation(string institution)
        {
            var filter = initialResume.Educations.Find(e => e.Institution == institution);
            if (filter != null)
            {
                int index = initialResume.Educations.FindIndex(0, e => e == filter);
                initialResume.Educations.RemoveAt(index);
                return NoContent();
            }
            else
            {
                return NotFound("Delete target not found");
            }

        }

        [BasicAuthorization]
        [HttpDelete("awards/{title}")]
        public ActionResult<Profile> DeleteAward(string title)
        {
            var filter = initialResume.Awards.Find(e => e.Title == title);
            if (filter != null)
            {
                int index = initialResume.Awards.FindIndex(0, e => e == filter);
                initialResume.Awards.RemoveAt(index);
                return NoContent();
            }
            else
            {
                return NotFound("Delete target not found");
            }

        }

        [BasicAuthorization]
        [HttpDelete("publications/{name}")]
        public ActionResult<Profile> DeletePublication(string name)
        {
            var filter = initialResume.Publications.Find(e => e.Name == name);
            if (filter != null)
            {
                int index = initialResume.Publications.FindIndex(0, e => e == filter);
                initialResume.Publications.RemoveAt(index);
                return NoContent();
            }
            else
            {
                return NotFound("Delete target not found");
            }

        }

        [BasicAuthorization]
        [HttpDelete("skills/{name}")]
        public ActionResult<Profile> DeleteSkill(string name)
        {
            var filter = initialResume.Skills.Find(e => e.Name == name);
            if (filter != null)
            {
                int index = initialResume.Skills.FindIndex(0, e => e == filter);
                initialResume.Skills.RemoveAt(index);
                return NoContent();
            }
            else
            {
                return NotFound("Delete target not found");
            }

        }

        [BasicAuthorization]
        [HttpDelete("languages/{name}")]
        public ActionResult<Profile> DeleteLanguages(string name)
        {
            var filter = initialResume.Languages.Find(e => e.Languag == name);
            if (filter != null)
            {
                int index = initialResume.Languages.FindIndex(0, e => e == filter);
                initialResume.Languages.RemoveAt(index);
                return NoContent();
            }
            else
            {
                return NotFound("Delete target not found");
            }

        }

        [BasicAuthorization]
        [HttpDelete("interests/{name}")]
        public ActionResult<Profile> DeleteInterests(string name)
        {
            var filter = initialResume.Interests.Find(e => e.Name == name);
            if (filter != null)
            {
                int index = initialResume.Interests.FindIndex(0, e => e == filter);
                initialResume.Interests.RemoveAt(index);
                return NoContent();
            }
            else
            {
                return NotFound("Delete target not found");
            }

        }

        [BasicAuthorization]
        [HttpDelete("references/{name}")]
        public ActionResult<Profile> DeleteReference(string name)
        {
            var filter = initialResume.References.Find(e => e.Name == name);
            if (filter != null)
            {
                int index = initialResume.References.FindIndex(0, e => e == filter);
                initialResume.References.RemoveAt(index);
                return NoContent();
            }
            else
            {
                return NotFound("Delete target not found");
            }

        }
        #endregion

        #region PatchMethods


        #endregion
    }
}
