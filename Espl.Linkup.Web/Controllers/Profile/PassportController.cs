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
        static List<Passport> pasportList = new List<Passport>();
        // GET: api/Passport/5
        public IHttpActionResult Get(int id)
        {
            var result = pasportList.Where(p => p.ID == id).FirstOrDefault();
            return Ok(result);
        }


        public IHttpActionResult Get()
        {

            pasportList.Add(new Passport
            {
                ID = 1,
                Number = "123456",
                ExpDate = new DateTime( 2020,12, 12),
                Status = "Approved",
                Comments = "upload proper scan copy of both pages"
            });
            pasportList.Add(new Passport
            {
                ID = 2,
                Number = "123456",
                ExpDate = new DateTime( 2020,12, 12),
                Status = "Approved",
                Comments = "upload proper scan copy of both pages"
            });
            return Ok(pasportList);
        }


        // POST: api/Passport
        public IHttpActionResult Post(Passport value)
        {
            pasportList.Add(value);
            value.ID = pasportList.Count;
            return Ok(value);
        }

        // PUT: api/Passport/5
        public IHttpActionResult Put(int id, Passport value)
        {
            Passport result = pasportList.Where(p => p.ID == id).FirstOrDefault();
            result.Number = value.Number;
            result.Status = value.Status;
            result.Comments = value.Comments;
            return Ok(result);
        }

        // DELETE: api/Passport/5
        public IHttpActionResult Delete(int id)
        {
            Passport result = pasportList.Where(p => p.ID == id).FirstOrDefault();
            var resultflag = pasportList.Remove(result);
            return Ok(resultflag);
        }
    }
}
