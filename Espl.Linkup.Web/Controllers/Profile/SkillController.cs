﻿using Espl.Linkup.Domain.Profile.Skill;
using Espl.Linkup.Domain.SkillTypes;
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
        static List<Skill> skilllist = new List<Skill>();
        // GET: api/Skill
        public IHttpActionResult Get()
        {

            skilllist.Add(new Skill
            {
                Description = "C#,Asp.net",
                Type = new SkillType {ID=1,Name="Progrming Lang" },
                Comments = "Good Work",
                ID = 1
            });
            skilllist.Add(new Skill
           {
               Description = "Sql",
               Type = new SkillType { ID = 2, Name = "Database" },
               Comments = "Good Work",
               ID = 2
           });
            return Ok(skilllist);
        }

        // GET: api/Skill/5
        public IHttpActionResult Get(int id)
        {
            var result = skilllist.Where(p => p.ID == id).FirstOrDefault();
            return Ok(result);
        }

        // POST: api/Skill
        public IHttpActionResult Post(Skill value)
        {
            skilllist.Add(value);
            value.ID = skilllist.Count;
            return Ok(value);
        }

        // PUT: api/Skill/5
        public IHttpActionResult Put(int id, Skill value)
        {
            Skill result = skilllist.Where(p => p.ID == id).FirstOrDefault();
            result.Description = value.Description;
            result.Type = value.Type;
            result.Comments = value.Comments;
            return Ok(result);
        }

        // DELETE: api/Skill/5
        public IHttpActionResult Delete(int id)
        {
            Skill result = skilllist.Where(p => p.ID == id).FirstOrDefault();
            var resultflag = skilllist.Remove(result);
            return Ok(resultflag);
        }
    }
}
