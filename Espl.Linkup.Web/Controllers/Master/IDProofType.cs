using Espl.Linkup.Domain.IDProofTypes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Espl.Linkup.Web.Controllers.Corporate
{
    public class IDProofTypeController : ApiController
    {
        // GET: api/IDProofType
        static List<IDProofType> IDProofTypeList = new List<IDProofType>();
        // GET: api/IDProofType
        public IHttpActionResult Get()
        {

            IDProofTypeList.Add(new IDProofType
            {
                ID = 1,
                Name="Adhar"
               
            });
            IDProofTypeList.Add(new IDProofType
            {
                Name = "PAN",
                ID = 2
            });
            return Ok(IDProofTypeList);
        }

        // GET: api/IDProofType/5
        public IHttpActionResult Get(int id)
        {
            var result = IDProofTypeList.Where(p => p.ID == id).FirstOrDefault();
            return Ok(result);
        }

        // POST: api/IDProofType
        public IHttpActionResult Post(IDProofType value)
        {
            IDProofTypeList.Add(value);
            value.ID = IDProofTypeList.Count;
            return Ok(value.ID);
        }

        // PUT: api/IDProofType/5
        public IHttpActionResult Put(int id, IDProofType value)
        {
            IDProofType result = IDProofTypeList.Where(p => p.ID == id).FirstOrDefault();
            result = value;
            return Ok(result);
        }

        // DELETE: api/IDProofType/5
        public IHttpActionResult Delete(int id)
        {
            IDProofType result = IDProofTypeList.Where(p => p.ID == id).FirstOrDefault();
            var resultflag = IDProofTypeList.Remove(result);
            return Ok(resultflag);
        }
    }
}
