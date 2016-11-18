using Espl.Linkup.Domain.Profile.Passport;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Espl.Linkup.Web.Controllers.Profile
{
    public class PassportController : ApiController
    {
  
        // GET: api/Passport/5
        public IHttpActionResult Get(int id)
        {
            return Ok(new Passport
            {
                ID = 1,
                PassportNumber = "123456",
                ExpDate = new DateTime(12, 12, 2020),
                Status = "Approved",
                Comments = "upload proper scan copy of both pages"
            });
        }

        // POST: api/Passport
        public void Post([FromBody]string value)
        {
        }

        // PUT: api/Passport/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/Passport/5
        public void Delete(int id)
        {
        }
    }
}
