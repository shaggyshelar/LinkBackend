using Espl.Linkup.Domain.SkillTypes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Espl.Linkup.Web.Controllers.Corporate
{
    public class SkillTypeController : ApiController
    {
        // GET: api/SkillType
        static List<SkillType> skillTypeList = new List<SkillType>();
        // GET: api/SkillType
        public IHttpActionResult Get()
        {

            skillTypeList.Add(new SkillType
            {
                ID = 1,
                Name="Programing"
               
            });
            skillTypeList.Add(new SkillType
            {
                Name = "Database",
                ID = 2
            });
            return Ok(skillTypeList);
        }

        // GET: api/SkillType/5
        public IHttpActionResult Get(int id)
        {
            var result = skillTypeList.Where(p => p.ID == id).FirstOrDefault();
            return Ok(result);
        }

        // POST: api/SkillType
        public IHttpActionResult Post(SkillType value)
        {
            skillTypeList.Add(value);
            value.ID = skillTypeList.Count;
            return Ok(value.ID);
        }

        // PUT: api/SkillType/5
        public IHttpActionResult Put(int id, SkillType value)
        {
            SkillType result = skillTypeList.Where(p => p.ID == id).FirstOrDefault();
            result = value;
            return Ok(result);
        }

        // DELETE: api/SkillType/5
        public IHttpActionResult Delete(int id)
        {
            SkillType result = skillTypeList.Where(p => p.ID == id).FirstOrDefault();
            var resultflag = skillTypeList.Remove(result);
            return Ok(resultflag);
        }
    }
}
