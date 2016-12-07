using Espl.Linkup.Common.Leave;
using Espl.Linkup.Domain.Leave.Approvers;
using Espl.Linkup.Domain.Profile.Users;
using Espl.Linkup.Domain.Projects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;


namespace Espl.Linkup.Web.Controllers.Leave.Approvers
{
    public class ApproverController : ApiController
    {
        static List<Approver> ApproverList = new List<Approver>();
        // GET: api/Approver
        public IHttpActionResult Get()
        {

            ApproverList.Add(new Approver
            {
                ID = 1,
                Project = new Project { ID = 1, Name = "First", Manager = new User { ID = 1, Name = "Test manager" } },
                Status = false,
                Leave = new Espl.Linkup.Domain.Leaves.Leave { ID = 1 }
            });
            ApproverList.Add(new Approver
            {
                ID = 2,
                Project = new Project { ID = 2, Name = "Second", Manager = new User { ID = 1, Name = "Test manager" } },
                Status = true,
                Leave = new Espl.Linkup.Domain.Leaves.Leave { ID = 1 }

            });
            return Ok(ApproverList);
        }

        // GET: api/Approver/5
        public IHttpActionResult Get(int id)
        {
            var result = ApproverList.Where(p => p.ID == id).FirstOrDefault();
            return Ok(result);
        }

        // POST: api/Approver
        public IHttpActionResult Post(Approver value)
        {
            ApproverList.Add(value);
            value.ID = ApproverList.Count;
            return Ok(value);
        }

        // PUT: api/Approver/5
        public IHttpActionResult Put(int id, Approver value)
        {
            Approver result = ApproverList.Where(p => p.ID == id).FirstOrDefault();
            result.ID = value.ID;
            result.Status = value.Status;
            return Ok(result);
        }

        // DELETE: api/Approver/5
        public IHttpActionResult Delete(int id)
        {
            Approver result = ApproverList.Where(p => p.ID == id).FirstOrDefault();
            var resultflag = ApproverList.Remove(result);
            return Ok(resultflag);
        }
    }
}
