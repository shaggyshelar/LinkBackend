using Espl.Linkup.Domain.Profile.UAN;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Espl.Linkup.Web.Controllers.Profile
{
    public class UANController : ApiController
    {
        static List<UAN> UANlist = new List<UAN>();
        // GET: api/UAN/5




        public IHttpActionResult Get()
        {

            UANlist.Add(new UAN
            {
                ID = 1,
                UANNumber = "123456",
                FromESPL = true,
                Status = "Approved",
                Comments = "Done"
            });
            UANlist.Add(new UAN
            {
                ID = 2,
                UANNumber = "123456",
                FromESPL = true,
                Status = "Approved",
                Comments = "Done"
            });
            return Ok(UANlist);
        }


        public IHttpActionResult Get(int id)
        {
            var result = UANlist.Where(p => p.ID == id).FirstOrDefault();
            return Ok(result);
        }

        // POST: api/UAN
        public IHttpActionResult Post(UAN value)
        {
            UANlist.Add(value);
            value.ID = UANlist.Count;
            return Ok(value);
        }

        // PUT: api/UAN/5
        public IHttpActionResult Put(int id, UAN value)
        {
            UAN result = UANlist.Where(p => p.ID == id).FirstOrDefault();
            result.UANNumber = value.UANNumber;
            result.Status = value.Status;
            result.FromESPL = value.FromESPL;
            result.Comments = value.Comments;
            return Ok(result);
        }

        // DELETE: api/UAN/5
        public IHttpActionResult Delete(int id)
        {
            UAN result = UANlist.Where(p => p.ID == id).FirstOrDefault();
            var resultflag = UANlist.Remove(result);
            return Ok(resultflag);
        }
    }
}
