using Espl.Linkup.Domain.Corporate.Ticket;
using Espl.Linkup.Domain.Departments;
using Espl.Linkup.Domain.Profile.Users;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Espl.Linkup.Web.Controllers.Corporate
{
    public class TicketController : ApiController
    {
        static List<Ticket> ticketList = new List<Ticket>();
        // GET: api/LogTicket
        public IHttpActionResult Get()
        {

            ticketList.Add(new Ticket
            {
                User = new User { ID = 1 },
                Concern = "Software Installation",
                Department = new Department{ID=1,Name="EBS"},
                Description = "Not able to connect with bit bucket",
                Priority = Espl.Linkup.Domain.Enums.Enum.Priority.High,
                CreatedOn = new DateTime(2016, 10, 10),
                Status = "Closed",
                Isclosed = true,
                IsReopen = true,
                ID = 1
            });

            return Ok(ticketList);
        }

        // GET: api/LogTicket/5
        public IHttpActionResult Get(int id)
        {
            var result = ticketList.Where(p => p.ID == id).FirstOrDefault();
            return Ok(result);
        }

        // POST: api/LogTicket
        public IHttpActionResult Post(Ticket value)
        {
            ticketList.Add(value);
            value.ID = ticketList.Count;
            return Ok(value);
        }

        // PUT: api/LogTicket/5
        public IHttpActionResult Put(int id, Ticket value)
        {

            Ticket result = ticketList.Where(p => p.ID == id).FirstOrDefault();
            result.Concern = value.Concern;
            result.Department = value.Department;
            result.Description = value.Description;
            result.Priority = value.Priority;
            result.CreatedOn = new DateTime(2016, 10, 10);
            result.Status = value.Status;
            result.Isclosed = value.Isclosed;
            result.IsReopen = value.IsReopen;
            return Ok(result);
        }

        // DELETE: api/LogTicket/5
        public IHttpActionResult Delete(int id)
        {
            Ticket result = ticketList.Where(p => p.ID == id).FirstOrDefault();
            var resultflag = ticketList.Remove(result);
            return Ok(resultflag);
        }
    }
}
