using Espl.Linkup.Domain.PFs;
using Espl.Linkup.Domain.Profile.Contact;
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
        static List<Employee> employeeList = new List<Employee>();
        // GET: api/Employee
        public IHttpActionResult Get()
        {

            employeeList.Add(
                new Employee
                {
                    ID = 10133,
                    Name = "Amol",
                    CurrentAdd = "Ravet",
                    ContactNo = "1234567890",
                    Email = "amol@gmail.com",
                    DOB = new DateTime(1988, 11, 28),
                    PF = new PF { ID = 1, PreviousOrgPFNumber = "123456", CurrentOrgPFNumber = "789456" },
                    CareerStartDate = new DateTime(2012, 11, 28),
                    LastWorkingDayOfPrevEmployer = new DateTime(1988, 11, 27),
                    Contact = new Contact { ID = 1, Name = "Amol", Number = "12569874" },
                    SkypeID = "123"
                }
                );

            return Ok(employeeList);
        }

        // GET: api/Employee/5
        public IHttpActionResult Get(int id)
        {
            var result = employeeList.Where(p => p.ID == id).FirstOrDefault();
            return Ok(result);
        }

        // POST: api/Employee
        public IHttpActionResult Post(Employee value)
        {
            employeeList.Add(value);
            value.ID = employeeList.Count;
            return Ok(value);
        }

        // PUT: api/Employee/5
        public IHttpActionResult Put(int id, Employee value)
        {
            Employee result = employeeList.Where(p => p.ID == id).FirstOrDefault();
            result.Name = result.Name;
            result.CurrentAdd = result.CurrentAdd;
            result.ContactNo = result.ContactNo;
            result.Email = result.Email;
            result.DOB = new DateTime(1988, 11, 28);
            result.PF = result.PF;
            result.CareerStartDate = new DateTime(2012, 11, 28);
            result.LastWorkingDayOfPrevEmployer = new DateTime(1988, 11, 27);
            result.Contact = result.Contact;
            result.SkypeID = result.SkypeID;
            return Ok(result);
        }

        // DELETE: api/Employee/5
        public IHttpActionResult Delete(int id)
        {
            Employee result = employeeList.Where(p => p.ID == id).FirstOrDefault();
            var resultflag = employeeList.Remove(result);
            return Ok(resultflag);
        }
    }
}
