using Espl.Linkup.Common.Certifications;
using Espl.Linkup.Domain.Profile.Certification;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Espl.Linkup.Web.Controllers.Profile
{
    public class CertificationController : ApiController
    {
        static List<Certification> certificationList = new List<Certification>();
        // GET: api/Certification
        public IHttpActionResult Get()
        {

            certificationList.Add(
                new Certification
                {
                    ID = 1,
                    Code = "70-480",
                    Date = new DateTime().AddDays(-10),
                    Status = "Approved",
                    Comments = "Great"
                }
                );

            return Ok(certificationList);
        }

        // GET: api/Certification/5
        public IHttpActionResult Get(int id)
        {
            var result = certificationList.Where(p => p.ID == id).FirstOrDefault();
            return Ok(result);
        }

        // POST: api/Certification
        public IHttpActionResult Post(Certification value)
        {
            certificationList.Add(value);
            value.ID = certificationList.Count;
            return Ok(value);
        }

        // PUT: api/Certification/5
        public IHttpActionResult Put(int id, Certification value)
        {
            Certification result = certificationList.Where(p => p.ID == id).FirstOrDefault();
            result.Code = value.Code;
            result.Date = new DateTime().AddDays(-10);
            result.Status = value.Status;
            result.Comments = value.Comments;
            return Ok(result);
        }

        // DELETE: api/Certification/5
        public IHttpActionResult Delete(int id)
        {
            Certification result = certificationList.Where(p => p.ID == id).FirstOrDefault();
            var resultflag = certificationList.Remove(result);
            return Ok(resultflag);
        }
    }
}
