using Espl.Linkup.Common.Corporate.Treatments;
using Espl.Linkup.Common.Users;
using Espl.Linkup.Domain.Corporate.Treatments;
using Espl.Linkup.Domain.Countries;
using Espl.Linkup.Domain.Profile.Users;
using Espl.Linkup.Domain.Roles;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Espl.Linkup.Web.Controllers.Corporate
{
    public class RoleController : ApiController
    {
        // GET: api/Role
        static List<Role> roleList = new List<Role>();
        // GET: api/Role
        public IHttpActionResult Get()
        {

            roleList.Add(new Role
            {
                ID = 1,
                Name="India"
               
            });
            roleList.Add(new Role
            {
                 Name="USA",
                ID = 2
            });
            return Ok(roleList);
        }

        // GET: api/Role/5
        public IHttpActionResult Get(int id)
        {
            var result = roleList.Where(p => p.ID == id).FirstOrDefault();
            return Ok(result);
        }

        // POST: api/Role
        public IHttpActionResult Post(Role value)
        {
            roleList.Add(value);
            value.ID = roleList.Count;
            return Ok(value);
        }

        // PUT: api/Role/5
        public IHttpActionResult Put(int id, Role value)
        {
            Role result = roleList.Where(p => p.ID == id).FirstOrDefault();
            result = value;
            return Ok(result);
        }

        // DELETE: api/Role/5
        public IHttpActionResult Delete(int id)
        {
            Role result = roleList.Where(p => p.ID == id).FirstOrDefault();
            var resultflag = roleList.Remove(result);
            return Ok(resultflag);
        }
    }
}
