using Espl.Linkup.Domain.Profile.Visa;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Espl.Linkup.Web.Controllers.Profile
{
    public class VisaController : ApiController
    {

        public IHttpActionResult Get()
        {
            List<Visa> visaList = new List<Visa>();
            visaList.Add(new Visa
            {
                VisaNumber = "123456",
                ExpDate = new DateTime(12, 12, 2020),
                Comments = "Dood Work",
                VisaType="L1",
                ID = 1
            });

            return Ok(visaList);
        }

        public IHttpActionResult Get(int id)
        {
            return Ok(new Visa
            {
                ID = 1,
                VisaNumber = "123456",
                Status = "Approved",
                Comments = "Done"
            });
        }
        // POST: api/Visa
        public void Post([FromBody]string value)
        {
        }

        // PUT: api/Visa/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/Visa/5
        public void Delete(int id)
        {
        }
    }
}
