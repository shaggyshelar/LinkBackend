using Espl.Linkup.Common.Corporate.Treatments;
using Espl.Linkup.Common.Users;
using Espl.Linkup.Domain.Corporate.Treatments;
using Espl.Linkup.Domain.Countries;
using Espl.Linkup.Domain.Profile.Users;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Espl.Linkup.Web.Controllers.Corporate
{
    public class CountryController : ApiController
    {
        // GET: api/Country
        static List<Country> countryList = new List<Country>();
        // GET: api/Country
        public IHttpActionResult Get()
        {

            countryList.Add(new Country
            {
                ID = 1,
                Name="India"
               
            });
            countryList.Add(new Country
            {
                 Name="USA",
                ID = 2
            });
            return Ok(countryList);
        }

        // GET: api/Country/5
        public IHttpActionResult Get(int id)
        {
            var result = countryList.Where(p => p.ID == id).FirstOrDefault();
            return Ok(result);
        }

        // POST: api/Country
        public IHttpActionResult Post(Country value)
        {
            countryList.Add(value);
            value.ID = countryList.Count;
            return Ok(value);
        }

        // PUT: api/Country/5
        public IHttpActionResult Put(int id, Country value)
        {
            Country result = countryList.Where(p => p.ID == id).FirstOrDefault();
            result = value;
            return Ok(result);
        }

        // DELETE: api/Country/5
        public IHttpActionResult Delete(int id)
        {
            Country result = countryList.Where(p => p.ID == id).FirstOrDefault();
            var resultflag = countryList.Remove(result);
            return Ok(resultflag);
        }
    }
}
