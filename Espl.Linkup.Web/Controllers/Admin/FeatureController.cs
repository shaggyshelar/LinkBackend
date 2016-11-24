using Espl.Linkup.Common.Corporate.Treatments;
using Espl.Linkup.Common.Users;
using Espl.Linkup.Domain.Corporate.Treatments;
using Espl.Linkup.Domain.Countries;
using Espl.Linkup.Domain.Profile.Users;
using Espl.Linkup.Domain.Features;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Espl.Linkup.Web.Controllers.Corporate
{
    public class FeatureController : ApiController
    {
        // GET: api/Feature
        static List<Feature> featureList = new List<Feature>();
        // GET: api/Feature
        public IHttpActionResult Get()
        {

            featureList.Add(new Feature
            {
                ID = 1,
                Name="First"
               
            });
            featureList.Add(new Feature
            {
                 Name="Second",
                ID = 2
            });
            return Ok(featureList);
        }

        // GET: api/Feature/5
        public IHttpActionResult Get(int id)
        {
            var result = featureList.Where(p => p.ID == id).FirstOrDefault();
            return Ok(result);
        }

        // POST: api/Feature
        public IHttpActionResult Post(Feature value)
        {
            featureList.Add(value);
            value.ID = featureList.Count;
            return Ok(value);
        }

        // PUT: api/Feature/5
        public IHttpActionResult Put(int id, Feature value)
        {
            Feature result = featureList.Where(p => p.ID == id).FirstOrDefault();
            result = value;
            return Ok(result);
        }

        // DELETE: api/Feature/5
        public IHttpActionResult Delete(int id)
        {
            Feature result = featureList.Where(p => p.ID == id).FirstOrDefault();
            var resultflag = featureList.Remove(result);
            return Ok(resultflag);
        }
    }
}
