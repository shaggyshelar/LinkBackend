using Espl.Linkup.Domain.Departments;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Espl.Linkup.Web.Controllers.Master
{
    public class DepartmentController : ApiController
    {
        // GET: api/Department
        static List<Department> departmentList = new List<Department>();
        // GET: api/Department
        public IHttpActionResult Get()
        {

            departmentList.Add(new Department
            {
                ID = 1,
                Name="EBS"
               
            });
            departmentList.Add(new Department
            {
                Name = "ECS",
                ID = 2
            });
            return Ok(departmentList);
        }

        // GET: api/Department/5
        public IHttpActionResult Get(int id)
        {
            var result = departmentList.Where(p => p.ID == id).FirstOrDefault();
            return Ok(result);
        }

        // POST: api/Department
        public IHttpActionResult Post(Department value)
        {
            departmentList.Add(value);
            value.ID = departmentList.Count;
            return Ok(value);
        }

        // PUT: api/Department/5
        public IHttpActionResult Put(int id, Department value)
        {
            Department result = departmentList.Where(p => p.ID == id).FirstOrDefault();
            result = value;
            return Ok(result);
        }

        // DELETE: api/Department/5
        public IHttpActionResult Delete(int id)
        {
            Department result = departmentList.Where(p => p.ID == id).FirstOrDefault();
            var resultflag = departmentList.Remove(result);
            return Ok(resultflag);
        }
    }
}
