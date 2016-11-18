using Espl.Linkup.Domain.Profile.Address;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Espl.Linkup.Web.Controllers.Profile
{
    public class AddressController : ApiController
    {
        static List<Address> addressList = new List<Address>();
      
        // GET: api/Address
        public IHttpActionResult Get()
        {
            addressList.Add(new Address {ID=1, CurrentAdd = "Ravet", PermanantAdd = "Aundh" });
            addressList.Add(new Address {ID=2,  CurrentAdd = "Ravet", PermanantAdd = "Aundh" });
            return Ok(addressList);
        }

        // GET: api/Address/5
        public IHttpActionResult Get(int id)
        {
            var result = addressList.Where(p => p.ID == id).FirstOrDefault();
            return Ok(result);
        }

        // POST: api/Address
        public IHttpActionResult Post(Address value)
        {
            addressList.Add(value);
            value.ID = addressList.Count;
            return Ok(value);
           
        }

        // PUT: api/Address/5
        public IHttpActionResult Put(int id, Address value)
        {
            Address result = addressList.Where(p => p.ID == id).FirstOrDefault();
            result.CurrentAdd = value.CurrentAdd;
            result.PermanantAdd = value.PermanantAdd;
            return Ok(result);
        }

        // DELETE: api/Address/5
        public IHttpActionResult Delete(int id)
        {
            Address result = addressList.Where(p => p.ID == id).FirstOrDefault();
            var resultflag = addressList.Remove(result);
            return Ok(resultflag);
        }
    }
}
