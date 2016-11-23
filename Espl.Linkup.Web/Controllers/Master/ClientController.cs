using Espl.Linkup.Domain.Clients;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Espl.Linkup.Web.Controllers.Corporate
{
    public class ClientController : ApiController
    {
        // GET: api/Client
        static List<Client> clientList = new List<Client>();
        // GET: api/Client
        public IHttpActionResult Get()
        {

            clientList.Add(new Client
            {
                ID = 1,
                Name="XTZ"
               
            });
            clientList.Add(new Client
            {
                Name = "ABC",
                ID = 2
            });
            return Ok(clientList);
        }

        // GET: api/Client/5
        public IHttpActionResult Get(int id)
        {
            var result = clientList.Where(p => p.ID == id).FirstOrDefault();
            return Ok(result);
        }

        // POST: api/Client
        public IHttpActionResult Post(Client value)
        {
            clientList.Add(value);
            value.ID = clientList.Count;
            return Ok(value.ID);
        }

        // PUT: api/Client/5
        public IHttpActionResult Put(int id, Client value)
        {
            Client result = clientList.Where(p => p.ID == id).FirstOrDefault();
            result = value;
            return Ok(result);
        }

        // DELETE: api/Client/5
        public IHttpActionResult Delete(int id)
        {
            Client result = clientList.Where(p => p.ID == id).FirstOrDefault();
            var resultflag = clientList.Remove(result);
            return Ok(resultflag);
        }
    }
}
