using Espl.Linkup.Common.Employee;
using Espl.Linkup.Domain.Leaves.LeaveDetail;
using Espl.Linkup.Domain.Profile.Employee;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Espl.Linkup.Web.Controllers.Leaves
{
    public class LeaveDetailController : ApiController
    {
        static List<Espl.Linkup.Common.Leaves.ILeave> leaveList = new List<Espl.Linkup.Common.Leaves.ILeave>();
        static List<LeaveDetail> leaveDetailList = new List<LeaveDetail>();
        // GET: api/LeaveDetail
        public IHttpActionResult Get()
        {


            IEmployee emp = new Employee();
            emp.Name = "Amol";
            emp.ID = 101;
            leaveList.Add(new Espl.Linkup.Domain.Leaves.Leave
            {
                ID = 1,
                NumberOfLeave = 12,
                Reason = "Sample",
                Status = "Approved",
                Employee = emp,
                StartDate = new DateTime( 2016,12, 12),
                EndDate = new DateTime(2016, 12, 18)

            });
            leaveList.Add(new Espl.Linkup.Domain.Leaves.Leave
            {
                ID = 2,
                NumberOfLeave = 12,
                Reason = "Sample Demo",
                Status = "Approved",
                Employee = emp,
                StartDate = new DateTime( 2016,11, 12),
                EndDate = new DateTime( 2016,11, 18)
            });

            leaveDetailList.Add(
                new LeaveDetail
            {
                ID = 1,
                Leavelst = leaveList,
                NumberOfLeave = 12,
                HalfDayAbsent = 0,
                HalfDayLeave = 1
            }
                );

            return Ok(leaveDetailList);
        }

        // GET: api/LeaveDetail/5
        public IHttpActionResult Get(int id)
        {
            var result = leaveDetailList.Where(p => p.ID == id).FirstOrDefault();
            return Ok(result);
        }

        // POST: api/LeaveDetail
        public void Post([FromBody]string value)
        {
        }

        // PUT: api/LeaveDetail/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/LeaveDetail/5
        public void Delete(int id)
        {
        }
    }
}
