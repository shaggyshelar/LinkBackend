using Espl.Linkup.Domain.ContactTypes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Espl.Linkup.Web.Controllers.Corporate
{
    public class ContactTypeController : ApiController
    {
        // GET: api/ContactType
        static List<ContactType> contactTypeList = new List<ContactType>();
        // GET: api/ContactType
        public IHttpActionResult Get()
        {

            contactTypeList.Add(new ContactType
            {
                ID = 1,
                Name="Emergency"
               
            });
            contactTypeList.Add(new ContactType
            {
                Name = "Personal",
                ID = 2
            });
            return Ok(contactTypeList);
        }

        // GET: api/ContactType/5
        public IHttpActionResult Get(int id)
        {
            var result = contactTypeList.Where(p => p.ID == id).FirstOrDefault();
            return Ok(result);
        }

        // POST: api/ContactType
        public IHttpActionResult Post(ContactType value)
        {
            contactTypeList.Add(value);
            value.ID = contactTypeList.Count;
            return Ok(value.ID);
        }

        // PUT: api/ContactType/5
        public IHttpActionResult Put(int id, ContactType value)
        {
            ContactType result = contactTypeList.Where(p => p.ID == id).FirstOrDefault();
            result = value;
            return Ok(result);
        }

        // DELETE: api/ContactType/5
        public IHttpActionResult Delete(int id)
        {
            ContactType result = contactTypeList.Where(p => p.ID == id).FirstOrDefault();
            var resultflag = contactTypeList.Remove(result);
            return Ok(resultflag);
        }
    }
}
