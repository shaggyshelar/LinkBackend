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

        static List<Nominee> nomineeList = new List<Nominee>();
        // GET: api/Nominee
        public IHttpActionResult Get()
        {
            nomineeList.Add(new Nominee
            {
                ID = 1,
                FirstNomineeName = "First",
                FirstNomineeRelationWithEmp = "Relation",
                SecondNomineeName = "Second",
                SecondNomineeRelationWithEmp = "Relation"
            });

            nomineeList.Add(new Nominee
            {
                ID = 2,
                FirstNomineeName = "Third",
                FirstNomineeRelationWithEmp = "Relation",
                SecondNomineeName = "Fourth",
                SecondNomineeRelationWithEmp = "Relation"
            });
            return Ok(nomineeList);
        }

        // GET: api/Nominee/5
        public IHttpActionResult Get(int id)
        {
            var result = nomineeList.Where(p => p.ID == id).FirstOrDefault();
            return Ok(result);
        }

        // POST: api/Nominee
        public IHttpActionResult Post(Nominee value)
        {
            nomineeList.Add(value);
            value.ID = nomineeList.Count;
            return Ok(value);
        }

        // PUT: api/Nominee/5
        public IHttpActionResult Put(int id, Nominee value)
        {
            Nominee result = nomineeList.Where(p => p.ID == id).FirstOrDefault();
            result.FirstNomineeName = value.FirstNomineeName;
            result.FirstNomineeRelationWithEmp = value.FirstNomineeRelationWithEmp;
            result.SecondNomineeName = value.SecondNomineeName;
            result.SecondNomineeRelationWithEmp = value.SecondNomineeRelationWithEmp;
            return Ok(result);
        }

        // DELETE: api/Nominee/5
        public IHttpActionResult Delete(int id)
        {
            Nominee result = nomineeList.Where(p => p.ID == id).FirstOrDefault();
            var resultflag = nomineeList.Remove(result);
            return Ok(resultflag);
        }
    }
}
