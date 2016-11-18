using Espl.Linkup.Domain.Profile.Experience;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Espl.Linkup.Web.Controllers.Profile
{
    public class ExperienceController : ApiController
    {
        // GET: api/Experience
        public IHttpActionResult Get()
        {
            List<Experience> experienceList = new List<Experience>();
            experienceList.Add(
                new Experience
                {
                    ID = 10133,
                    StartDate = new DateTime(2012, 06, 12),
                    EndDate = new DateTime(2016, 06, 12),
                    Duration = "4 Years",
                    Status = "Approved",
                    Comments = "Approved",
                    Project = "JUSTAarogyam",
                    Client = "Self",
                    Role = "Devloper",
                    Environment = ".net",
                    CurrentProject = true,
                }
                );

            return Ok(experienceList);
        }

        // GET: api/Experience/5
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/Experience
        public void Post([FromBody]string value)
        {
        }

        // PUT: api/Experience/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/Experience/5
        public void Delete(int id)
        {
        }
    }
}
