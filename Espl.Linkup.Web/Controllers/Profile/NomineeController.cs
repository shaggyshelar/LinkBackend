using Espl.Linkup.Domain.Profile.Nominee;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Espl.Linkup.Web.Controllers.Profile
{
    public class NomineeController : ApiController
    {
        // GET: api/Nominee
        public IHttpActionResult Get()
        {
            return Ok(new Nominee
            {
                ID = 1,
                FirstNomineeName = "First",
                FirstNomineeRelationWithEmp = "Relation",
                SecondNomineeName = "Second",
                SecondNomineeRelationWithEmp = "Relation"
            });
        }

        // GET: api/Nominee/5
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/Nominee
        public void Post([FromBody]string value)
        {
        }

        // PUT: api/Nominee/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/Nominee/5
        public void Delete(int id)
        {
        }
    }
}
