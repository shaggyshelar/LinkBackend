using Espl.Linkup.Domain.Profile.Employee;
using Espl.Linkup.Domain.Projects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Espl.Linkup.Web.Controllers.Projects
{
    public class ProjectController : ApiController
    {
        static List<Project> projectList = new List<Project>();
        // GET: api/Project
        public IHttpActionResult Get()
        {

            projectList.Add(new Project
            {
                ProjectName = "First",
                ProjectManager = new Employee { ID = 1, Name = "Amol 1" },
                ID = 1
            });
            projectList.Add(new Project
            {
                ProjectName = "Second",
                ProjectManager = new Employee { ID = 1, Name = "Amol 2" },
                ID = 1
            });

            return Ok(projectList);
        }

        // GET: api/Project/5
        public IHttpActionResult Get(int id)
        {
            var result = projectList.Where(p => p.ID == id).FirstOrDefault();
            return Ok(result);
        }

        // POST: api/Project
        public IHttpActionResult Post(Project value)
        {
            Project result = new Project();
            result.ProjectName = value.ProjectName;
            result.ProjectManager = value.ProjectManager;
            projectList.Add(result);
            result.ID = projectList.Count;
            return Ok(result.ID);
        }

        // PUT: api/Project/5
        public IHttpActionResult Put(int id, Project value)
        {
            Project result = projectList.Where(p => p.ID == id).FirstOrDefault();
            result.ProjectName = value.ProjectName;
            result.ProjectManager = value.ProjectManager;
            return Ok(result);
        }

        // DELETE: api/Project/5
        public IHttpActionResult Delete(int id)
        {
            Project result = projectList.Where(p => p.ID == id).FirstOrDefault();
            var resultflag = projectList.Remove(result);
            return Ok(resultflag);
        }
    }
}
