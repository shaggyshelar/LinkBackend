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
        // GET: api/EmploymentHistory
        public IHttpActionResult Get()
        {
            List<EmploymentHistory> employmentHistoryList = new List<EmploymentHistory>();
            employmentHistoryList.Add(
                new EmploymentHistory
                {
                    ID = 10133,
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
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/EmploymentHistory
        public void Post([FromBody]string value)
        {
        }

        // PUT: api/EmploymentHistory/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/EmploymentHistory/5
        public void Delete(int id)
        {
        }
    }
}
