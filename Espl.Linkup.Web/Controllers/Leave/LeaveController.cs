using Espl.Linkup.Common.Employee;
using Espl.Linkup.Domain.Profile.Employee;
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
            IEmployee emp = new Employee();
            emp.Name = "Amol";
            emp.ID = 101;
            leaveList.Add(new Espl.Linkup.Domain.Leaves.Leave
            {
                ID = 1,
                NumberOFLeave = 12,
                Reason = "Sample",
                Status = "Approved",
                Employee = emp,
                StartDate = new DateTime(12, 12, 2016),
                EndDate = new DateTime(12, 18, 2016)

            });
            leaveList.Add(new Espl.Linkup.Domain.Leaves.Leave
            {
                ID = 2,
                NumberOFLeave = 12,
                Reason = "Sample Demo",
                Status = "Approved",
                Employee = emp,
                StartDate = new DateTime(11, 12, 2016),
                EndDate = new DateTime(11, 18, 2016)
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
            return Ok(true);
        }

        // PUT: api/Leave/5
        public IHttpActionResult Put(int id, Espl.Linkup.Domain.Leaves.Leave value)
        {
            Espl.Linkup.Domain.Leaves.Leave result = leaveList.Where(p => p.ID == id).FirstOrDefault();
            result.ID = value.ID;
            result.NumberOFLeave = result.NumberOFLeave;
            result.Reason = result.Reason;
            result.Status = result.Status;
            result.StartDate = result.StartDate;
            result.EndDate = result.EndDate;
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
