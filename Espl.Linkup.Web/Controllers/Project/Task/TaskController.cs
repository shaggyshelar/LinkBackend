using Espl.Linkup.Domain.Projects.Tasks;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Espl.Linkup.Web.Controllers.Projects.Tasks
{
    public class TaskController : ApiController
    {
        static List<Task> taskList = new List<Task>();
        // GET: api/Task
        public IHttpActionResult Get()
        {

            taskList.Add(new Task
            {
                TaskName = "Development",
                ID = 1
            });
            taskList.Add(new Task
            {
                TaskName = "Req Analysis",
                ID = 2
            });

            taskList.Add(new Task
            {
                TaskName = "Deployment",
                ID = 2
            });

            return Ok(taskList);
        }

        // GET: api/Task/5
        public IHttpActionResult Get(int id)
        {
            var result = taskList.Where(p => p.ID == id).FirstOrDefault();
            return Ok(result);
        }

        // POST: api/Task
        public IHttpActionResult Post(Task value)
        {
            Task result = new Task();
            result.TaskName = value.TaskName;
            taskList.Add(result);
            result.ID = taskList.Count;
            return Ok(result.ID);
        }

        // PUT: api/Task/5
        public IHttpActionResult Put(int id, Task value)
        {
            Task result = taskList.Where(p => p.ID == id).FirstOrDefault();
            result.TaskName = value.TaskName;
            return Ok(result);
        }

        // DELETE: api/Task/5
        public IHttpActionResult Delete(int id)
        {
            Task result = taskList.Where(p => p.ID == id).FirstOrDefault();
            var resultflag = taskList.Remove(result);
            return Ok(resultflag);
        }
    }
}
