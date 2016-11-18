using Espl.Linkup.Domain.Profile.Skill;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Espl.Linkup.Web.Controllers.Profile
{
    public class SkillController : ApiController
    {
        // GET: api/Skill
        public IHttpActionResult Get()
        {
            List<Skill> skilllist = new List<Skill>();
            skilllist.Add(new Skill
            {
                Skills = "C#,Asp.net",
                SkillType="Programing lang",
                Comments = "Good Work",
                ID = 1
            });
             skilllist.Add(new Skill
            {
                Skills = "Sql",
                SkillType="Database",
                Comments = "Good Work",
                ID = 2
            });
            return Ok(skilllist);
        }

        // GET: api/Skill/5
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/Skill
        public void Post([FromBody]string value)
        {
        }

        // PUT: api/Skill/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/Skill/5
        public void Delete(int id)
        {
        }
    }
}
