using Espl.Linkup.Domain.Corporate.Ticket;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Espl.Linkup.Web.Controllers.Corporate
{
    public class LogTicketController : ApiController
    {
        static List<Ticket> TicketList = new List<Ticket>();
        // GET: api/LogTicket
        public IHttpActionResult Get()
        {

            TicketList.Add(new Ticket
            {
                Concern = "Software Installation",
                Department = "IT",
                Description = "Not able to connect with bit bucket",
                Priority = "High",
                CreatedOn = new DateTime(10, 10, 2016),
                Status = "Closed",
                Isclosed = true,
                IsReopen = true,
                ID = 1
            });

            return Ok(TicketList);
        }

        // GET: api/LogTicket/5
        public IHttpActionResult Get(int id)
        {
            var result = TicketList.Where(p => p.ID == id).FirstOrDefault();
            return Ok(result);
        }

        // POST: api/LogTicket
        public IHttpActionResult Post(Ticket value)
        {
            Ticket result = new Ticket();
            result.Concern = value.Concern;
            result.Department = value.Department;
            result.Description = value.Description;
            result.Priority = value.Priority;
            result.CreatedOn = new DateTime(10, 10, 2016);
            result.Status = value.Status;
            result.Isclosed = value.Isclosed;
            result.IsReopen = value.IsReopen;
            TicketList.Add(result);
            result.ID = TicketList.Count;
            return Ok(true);
        }

        // PUT: api/LogTicket/5
        public IHttpActionResult Put(int id, Ticket value)
        {

            Ticket result = TicketList.Where(p => p.ID == id).FirstOrDefault();
            result.Concern = value.Concern;
            result.Department = value.Department;
            result.Description = value.Description;
            result.Priority = value.Priority;
            result.CreatedOn = new DateTime(10, 10, 2016);
            result.Status = value.Status;
            result.Isclosed = value.Isclosed;
            result.IsReopen = value.IsReopen;
            TicketList.Add(result);
            result.ID = TicketList.Count;
            return Ok(result);
        }

        // DELETE: api/LogTicket/5
        public IHttpActionResult Delete(int id)
        {
            Ticket result = TicketList.Where(p => p.ID == id).FirstOrDefault();
            var resultflag = TicketList.Remove(result);
            return Ok(resultflag);
        }
    }
}
