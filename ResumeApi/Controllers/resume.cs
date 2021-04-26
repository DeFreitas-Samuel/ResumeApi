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
        static Resume initialResume = new Resume(basic);
        static int version = 1;

        #region GetMethods
        [HttpGet]
        public ActionResult<Resume> Get()
        {
            return initialResume;
        }

        [HttpGet("basics")]
        public ActionResult<Basic> GetBasic()
        {
            return initialResume.Basic;
        }

        #endregion
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<resume>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<resume>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
