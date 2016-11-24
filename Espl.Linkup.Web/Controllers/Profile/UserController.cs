using Espl.Linkup.Domain.PFs;
using Espl.Linkup.Domain.Profile.Contact;
using Espl.Linkup.Domain.Profile.Users;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Espl.Linkup.Web.Controllers.Profile
{
    public class UserController : ApiController
    {
        static List<User> UserList = new List<User>();
        // GET: api/User
        public IHttpActionResult Get()
        {

            UserList.Add(
                new User
                {
                    ID = 1,
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

            return Ok(UserList);
        }

        // GET: api/User/5
        public IHttpActionResult Get(int id)
        {
            var result = UserList.Where(p => p.ID == id).FirstOrDefault();
            return Ok(result);
        }

        // POST: api/User
        public IHttpActionResult Post(User value)
        {
            UserList.Add(value);
            value.ID = UserList.Count;
            return Ok(value);
        }

        // PUT: api/User/5
        public IHttpActionResult Put(int id, User value)
        {
            User result = UserList.Where(p => p.ID == id).FirstOrDefault();
            result.Name = value.Name;
            result.CurrentAdd = value.CurrentAdd;
            result.ContactNo = value.ContactNo;
            result.Email = value.Email;
            result.DOB = new DateTime(1988, 11, 28);
            result.PF = value.PF;
            result.CareerStartDate = new DateTime(2012, 11, 28);
            result.LastWorkingDayOfPrevEmployer = new DateTime(1988, 11, 27);
            result.Contact = value.Contact;
            result.SkypeID = value.SkypeID;
            return Ok(result);
        }

        // DELETE: api/User/5
        public IHttpActionResult Delete(int id)
        {
            User result = UserList.Where(p => p.ID == id).FirstOrDefault();
            var resultflag = UserList.Remove(result);
            return Ok(resultflag);
        }
    }
}
