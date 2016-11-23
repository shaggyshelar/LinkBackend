using Espl.Linkup.Domain.PFs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Espl.Linkup.Web.Controllers.Corporate
{
    public class PFController : ApiController
    {
        // GET: api/PF
        static List<PF> pfList = new List<PF>();
        // GET: api/PF
        public IHttpActionResult Get()
        {

            pfList.Add(new PF
            {
                ID = 1,
                CurrentOrgPFNumber = "123",
                PreviousOrgPFNumber = "565"

            });
            pfList.Add(new PF
            {
                CurrentOrgPFNumber = "12553",
                PreviousOrgPFNumber = "565999",
                ID = 2
            });
            return Ok(pfList);
        }

        // GET: api/PF/5
        public IHttpActionResult Get(int id)
        {
            var result = pfList.Where(p => p.ID == id).FirstOrDefault();
            return Ok(result);
        }

        // POST: api/PF
        public IHttpActionResult Post(PF value)
        {
            pfList.Add(value);
            value.ID = pfList.Count;
            return Ok(value.ID);
        }

        // PUT: api/PF/5
        public IHttpActionResult Put(int id, PF value)
        {
            PF result = pfList.Where(p => p.ID == id).FirstOrDefault();
            result = value;
            return Ok(result);
        }

        // DELETE: api/PF/5
        public IHttpActionResult Delete(int id)
        {
            PF result = pfList.Where(p => p.ID == id).FirstOrDefault();
            var resultflag = pfList.Remove(result);
            return Ok(resultflag);
        }
    }
}
