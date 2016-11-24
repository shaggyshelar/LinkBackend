using Espl.Linkup.Common.Achievement;
using Espl.Linkup.Domain.Profile.Achievement;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Espl.Linkup.Web.Controllers.Profile
{
    public class AchievementController : ApiController
    {
        static List<Achievement> achievementList = new List<Achievement>();
        // GET: api/Achievement
        public IHttpActionResult Get()
        {

            achievementList.Add(new Achievement
            {
                Name = "Spot Award",
                Comments = "Good Work",
                ID = 1
            });

            return Ok(achievementList);
        }

        // GET: api/Achievement/5
        public IHttpActionResult Get(int id)
        {
            var result = achievementList.Where(p => p.ID == id).FirstOrDefault();
            return Ok(result);
        }

        // POST: api/Achievement
        public IHttpActionResult Post(Achievement value)
        {
            achievementList.Add(value);
            value.ID = achievementList.Count;
            return Ok(value);
        }

        // PUT: api/Achievement/5
        public IHttpActionResult Put(int id, Achievement value)
        {
            Achievement result = achievementList.Where(p => p.ID == id).FirstOrDefault();
            result.ID = id;
            result.Name = value.Name;
            result.Comments = value.Comments;
            return Ok(result);
        }

        // DELETE: api/Achievement/5
        public IHttpActionResult Delete(int id)
        {
            Achievement result = achievementList.Where(p => p.ID == id).FirstOrDefault();
            var resultflag = achievementList.Remove(result);
            return Ok(resultflag);
        }
    }
}
