using Espl.Linkup.Domain.IDProofTypes;
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
        static List<IDProof> IDProofList = new List<IDProof>();
        // GET: api/IDProof
        public IHttpActionResult Get()
        {

            IDProofList.Add(
                new IDProof
                {
                    ID = 1,
                    Type = new IDProofType { ID=1,Name="PAN Card" },
                    FilePath = "abc.pdf",
                    Value = "123123123",
                    Status = "Approved",
                    Comments = "Approved",

                }
                );

            return Ok(IDProofList);
        }

        // GET: api/IDProof/5
        public IHttpActionResult Get(int id)
        {
            var result = IDProofList.Where(p => p.ID == id).FirstOrDefault();
            return Ok(result);
        }

        // POST: api/IDProof
        public IHttpActionResult Post(IDProof value)
        {
            IDProofList.Add(value);
            value.ID = IDProofList.Count;
            return Ok(value);
        }

        // PUT: api/IDProof/5
        public IHttpActionResult Put(int id, IDProof value)
        {
            IDProof result = IDProofList.Where(p => p.ID == id).FirstOrDefault();
            result.Type = value.Type;
            result.Value = value.Value;
            result.Status = value.Status;
            result.Comments = value.Comments;
            return Ok(result);
        }


        // DELETE: api/IDProof/5
        public IHttpActionResult Delete(int id)
        {
            IDProof result = IDProofList.Where(p => p.ID == id).FirstOrDefault();
            var resultflag = IDProofList.Remove(result);
            return Ok(resultflag);
        }
    }
}
