using Espl.Linkup.Domain.Profile.IDProof;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Espl.Linkup.Web.Controllers.Profile
{
    public class IDProofController : ApiController
    {
        // GET: api/IDProof
        public IHttpActionResult Get()
        {
            List<IDProof> IDProofList = new List<IDProof>();
            IDProofList.Add(
                new IDProof
                {
                    ID = 1,
                        
                    IDProofType="Adhar Card",
                    IDProofFilePath="abc.pdf",
                    Value="123123123",
                    Status = "Approved",
                    Comments = "Approved",

                }
                );

            return Ok(IDProofList);
        }

        // GET: api/IDProof/5
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/IDProof
        public void Post([FromBody]string value)
        {
        }

        // PUT: api/IDProof/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/IDProof/5
        public void Delete(int id)
        {
        }
    }
}
