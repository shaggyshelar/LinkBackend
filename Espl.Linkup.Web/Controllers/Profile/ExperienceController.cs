using Espl.Linkup.Domain.Clients;
using Espl.Linkup.Domain.Profile.Experience;
using Espl.Linkup.Domain.Projects;
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
        static List<Experience> experienceList = new List<Experience>();
        // GET: api/Experience
        public IHttpActionResult Get()
        {
            experienceList.Add(
                new Experience
                {
                    ID = 10133,
                    StartDate = new DateTime(2012, 06, 12),
                    EndDate = new DateTime(2016, 06, 12),
                    Duration = "4 Years",
                    Status = "Approved",
                    Comments = "Approved",
                    Project=new Project{ID=1,Name="Linkup" },
                    // Project = "JUSTAarogyam",
                    Client = new Client { ID = 1, Name = "Self" },
                    Role = "Devloper",
                    Environment = ".net",
                    IsCurrentProject = true,
                }
                );

            return Ok(experienceList);
        }

        // GET: api/Experience/5
        public IHttpActionResult Get(int id)
        {
            var result = experienceList.Where(p => p.ID == id).FirstOrDefault();
            return Ok(result);
        }

        // POST: api/Experience
        public IHttpActionResult Post(Experience value)
        {
            experienceList.Add(value);
            value.ID = experienceList.Count;
            return Ok(value);
        }

        // PUT: api/Experience/5
        public IHttpActionResult Put(int id, Experience value)
        {
            Experience result = experienceList.Where(p => p.ID == id).FirstOrDefault();
            result.Project = result.Project;
            result.Client = result.Client;
            result.Role = result.Role;
            result.Environment = result.Environment;
            result.StartDate = new DateTime(2012, 06, 12);
            result.EndDate = new DateTime(2016, 06, 12);
            result.Duration = value.Duration;
            result.Status = value.Status;
            result.Comments = value.Comments;
            return Ok(result);
        }

        // DELETE: api/Experience/5
        public IHttpActionResult Delete(int id)
        {
            Experience result = experienceList.Where(p => p.ID == id).FirstOrDefault();
            var resultflag = experienceList.Remove(result);
            return Ok(resultflag);
        }
    }
}
