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
        static List<Visa> visaList = new List<Visa>();
        public IHttpActionResult Get()
        {

            visaList.Add(new Visa
            {
                Number = "123456",
                ExpDate = new DateTime( 2020,12, 12),
                Comments = "Good Work",
                Type = "L1",
                ID = 1
            });

            visaList.Add(new Visa
            {
                Number = "123456",
                ExpDate = new DateTime(2020,12, 12),
                Comments = "Good Work",
                Type = "H1",
                ID = 2
            });
            return Ok(visaList);
        }

        public IHttpActionResult Get(int id)
        {
            var result = visaList.Where(p => p.ID == id).FirstOrDefault();
            return Ok(result);
        }
        // POST: api/Visa
        public IHttpActionResult Post(Visa value)
        {
            visaList.Add(value);
            value.ID = visaList.Count;
            return Ok(value);
        }

        // PUT: api/Visa/5
        public IHttpActionResult Put(int id, Visa value)
        {
            Visa result = visaList.Where(p => p.ID == id).FirstOrDefault();
            result.Number = value.Number;
            result.ExpDate = new DateTime( 2020,12, 12);
            result.Comments = value.Comments;
            result.Type = value.Type;
            return Ok(result);
        }

        // DELETE: api/Visa/5
        public IHttpActionResult Delete(int id)
        {
            Visa result = visaList.Where(p => p.ID == id).FirstOrDefault();
            var resultflag = visaList.Remove(result);
            return Ok(resultflag);
        }
    }
}
