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
        // GET: api/UAN/5
        public IHttpActionResult Get(int id)
        {
            return Ok(new UAN
            {
                ID = 1,
                UANNumber = "123456",
                FromESPL = true,
                Status = "Approved",
                Comments = "Done"
            });
        }

        // POST: api/UAN
        public void Post([FromBody]string value)
        {
        }

        // PUT: api/UAN/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/UAN/5
        public void Delete(int id)
        {
        }
    }
}
