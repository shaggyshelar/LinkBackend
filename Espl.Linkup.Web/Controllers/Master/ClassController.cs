using Espl.Linkup.Common.Corporate.Treatments;
using Espl.Linkup.Common.Employee;
using Espl.Linkup.Domain.Classes;
using Espl.Linkup.Domain.Corporate.Treatments;
using Espl.Linkup.Domain.Countries;
using Espl.Linkup.Domain.Profile.Employee;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Espl.Linkup.Web.Controllers.Corporate
{
    public class ClassController : ApiController
    {
        // GET: api/Class
        static List<Class> classList = new List<Class>();
        // GET: api/Class
        public IHttpActionResult Get()
        {

            classList.Add(new Class
            {
                ID = 1,
                Name="Post Graduation"
               
            });
            classList.Add(new Class
            {
                Name = "Graduation",
                ID = 2
            });
            return Ok(classList);
        }

        // GET: api/Class/5
        public IHttpActionResult Get(int id)
        {
            var result = classList.Where(p => p.ID == id).FirstOrDefault();
            return Ok(result);
        }

        // POST: api/Class
        public IHttpActionResult Post(Class value)
        {
            classList.Add(value);
            value.ID = classList.Count;
            return Ok(value.ID);
        }

        // PUT: api/Class/5
        public IHttpActionResult Put(int id, Class value)
        {
            Class result = classList.Where(p => p.ID == id).FirstOrDefault();
            result = value;
            return Ok(result);
        }

        // DELETE: api/Class/5
        public IHttpActionResult Delete(int id)
        {
            Class result = classList.Where(p => p.ID == id).FirstOrDefault();
            var resultflag = classList.Remove(result);
            return Ok(resultflag);
        }
    }
}
