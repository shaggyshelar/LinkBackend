using Espl.Linkup.Common.Users;
using Espl.Linkup.Domain.Profile.Users;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;


namespace Espl.Linkup.Web.Controllers.Leaves
{
    public class LeaveController : ApiController
    {
        static List<Espl.Linkup.Domain.Leaves.Leave> leaveList = new List<Espl.Linkup.Domain.Leaves.Leave>();
        // GET: api/Leave
        public IHttpActionResult Get()
        {
            IUser emp = new User();
            emp.Name = "Amol";
            emp.ID = 101;
            leaveList.Add(new Espl.Linkup.Domain.Leaves.Leave
            {
                ID = 1,
                NumberOfLeave = 12,
                Reason = "Sample",
                Status = "Approved",
                User = emp,
                StartDate = new DateTime(2016, 12, 12),
                EndDate = new DateTime(2016,12,18)

            });
            leaveList.Add(new Espl.Linkup.Domain.Leaves.Leave
            {
                ID = 2,
                NumberOfLeave = 12,
                Reason = "Sample Demo",
                Status = "Approved",
                User = emp,
                StartDate = new DateTime(2016,11, 12),
                EndDate = new DateTime(2016,11,18)
            });
            return Ok(leaveList);
        }

        // GET: api/Leave/5
        public IHttpActionResult Get(int id)
        {
            var result = leaveList.Where(p => p.ID == id).FirstOrDefault();
            return Ok(result);
        }

        // POST: api/Leave
        public IHttpActionResult Post(Espl.Linkup.Domain.Leaves.Leave value)
        {
            leaveList.Add(value);
            value.ID = leaveList.Count;
            return Ok(value);
        }

        // PUT: api/Leave/5
        public IHttpActionResult Put(int id, Espl.Linkup.Domain.Leaves.Leave value)
        {
            Espl.Linkup.Domain.Leaves.Leave result = leaveList.Where(p => p.ID == id).FirstOrDefault();
            result.ID = value.ID;
            result.NumberOfLeave = value.NumberOfLeave;
            result.Reason = value.Reason;
            result.Status = value.Status;
            result.StartDate = value.StartDate;
            result.EndDate = value.EndDate;
            return Ok(result);
        }

        // DELETE: api/Leave/5
        public IHttpActionResult Delete(int id)
        {
            Espl.Linkup.Domain.Leaves.Leave result = leaveList.Where(p => p.ID == id).FirstOrDefault();
            var resultflag = leaveList.Remove(result);
            return Ok(resultflag);
        }
    }
}
