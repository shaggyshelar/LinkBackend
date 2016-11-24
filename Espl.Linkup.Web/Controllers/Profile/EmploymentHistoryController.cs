using Espl.Linkup.Domain.Profile.EmploymentHistory;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Espl.Linkup.Web.Controllers.Profile
{
    public class EmploymentHistoryController : ApiController
    {
        static List<EmploymentHistory> employmentHistoryList = new List<EmploymentHistory>();
        // GET: api/EmploymentHistory
        public IHttpActionResult Get()
        {

            employmentHistoryList.Add(
                new EmploymentHistory
                {
                    ID = 1,
                    EmploymentDetail = "google",
                    Designation = "Developer",
                    StartDate = new DateTime(2012, 06, 12),
                    EndDate = new DateTime(2016, 06, 12),
                    Duration = "4 Years",
                    Status = "Approved",
                    Comments = "Approved",
                    FirstEmployerRelieving = "abc.pdf",
                    SecondEmployerRelieving = "abc.pdf",
                    FirstMonthSalarySlip = "abc.pdf",
                    SecondMonthSalarySlip = "abc.pdf",
                    ThirdMonthSalarySlip = "abc.pdf",
                }
                );

            return Ok(employmentHistoryList);
        }

        // GET: api/EmploymentHistory/5
        public IHttpActionResult Get(int id)
        {
            var result = employmentHistoryList.Where(p => p.ID == id).FirstOrDefault();
            return Ok(result);
        }

        // POST: api/EmploymentHistory
        public IHttpActionResult Post(EmploymentHistory value)
        {
            employmentHistoryList.Add(value);
            value.ID = employmentHistoryList.Count;
            return Ok(value);
        }

        // PUT: api/EmploymentHistory/5
        public IHttpActionResult Put(int id, EmploymentHistory value)
        {
            EmploymentHistory result = employmentHistoryList.Where(p => p.ID == id).FirstOrDefault();
            result.EmploymentDetail = value.EmploymentDetail;
            result.Designation = value.Designation;
            result.StartDate = new DateTime(2012, 06, 12);
            result.EndDate = new DateTime(2016, 06, 12);
            result.Duration = value.Duration;
            result.Status = value.Status;
            result.Comments = value.Comments;
            return Ok(result);
        }

        // DELETE: api/EmploymentHistory/5
        public IHttpActionResult Delete(int id)
        {
            EmploymentHistory result = employmentHistoryList.Where(p => p.ID == id).FirstOrDefault();
            var resultflag = employmentHistoryList.Remove(result);
            return Ok(resultflag);
        }
    }
}
