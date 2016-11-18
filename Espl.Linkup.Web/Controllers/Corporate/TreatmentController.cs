using Espl.Linkup.Domain.Corporate.Treatments;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Espl.Linkup.Web.Controllers.Corporate.Treatments
{
    public class TreatmentController : ApiController
    {
        // GET: api/Treatment
        static List<Treatment> TreatmentList = new List<Treatment>();
        // GET: api/Treatment
        public IHttpActionResult Get()
        {

            TreatmentList.Add(new Treatment
            {
                TreatmentName = "First",
                ID = 1
            });
            TreatmentList.Add(new Treatment
            {
                TreatmentName = "Second",
                ID = 2
            });

            return Ok(TreatmentList);
        }

        // GET: api/Treatment/5
        public IHttpActionResult Get(int id)
        {
            var result = TreatmentList.Where(p => p.ID == id).FirstOrDefault();
            return Ok(result);
        }

        // POST: api/Treatment
        public IHttpActionResult Post(Treatment value)
        {
            Treatment result = new Treatment();
            result.TreatmentName = value.TreatmentName;
            TreatmentList.Add(result);
            result.ID = TreatmentList.Count;
            return Ok(result.ID);
        }

        // PUT: api/Treatment/5
        public IHttpActionResult Put(int id, Treatment value)
        {
            Treatment result = TreatmentList.Where(p => p.ID == id).FirstOrDefault();
            result.TreatmentName = value.TreatmentName;
            return Ok(result);
        }

        // DELETE: api/Treatment/5
        public IHttpActionResult Delete(int id)
        {
            Treatment result = TreatmentList.Where(p => p.ID == id).FirstOrDefault();
            var resultflag = TreatmentList.Remove(result);
            return Ok(resultflag);
        }
    }
}
