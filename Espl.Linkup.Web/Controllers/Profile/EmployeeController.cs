using Espl.Linkup.Domain.Profile.Employee;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Espl.Linkup.Web.Controllers.Profile
{
    public class EmployeeController : ApiController
    {
        // GET: api/Employee
        public IHttpActionResult Get()
        {
            List<Employee> employeeList = new List<Employee>();
            employeeList.Add(
                new Employee
                {
                    ID = 10133,
                    Name = "Amol",
                    CurrentAdd = "Ravet",
                    ContactNo = "1234567890",
                    Email = "amol@gmail.com",
                    DOB = new DateTime(1988, 11, 28),
                    ESPL_PF_No = "123",
                    PreviousPFNo = "N/A",
                    CareerStartDate = new DateTime(2012, 11, 28),
                    LastWorkingDayOfPrevEmployer = new DateTime(1988, 11, 27),
                    EmergencyContactName = "Amol",
                    EmergencyContactNumber = "1234567890",
                    SkypeID = "123"
                }
                );

            return Ok(employeeList);
        }

        // GET: api/Employee/5
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/Employee
        public void Post([FromBody]string value)
        {
        }

        // PUT: api/Employee/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/Employee/5
        public void Delete(int id)
        {
        }
    }
}
