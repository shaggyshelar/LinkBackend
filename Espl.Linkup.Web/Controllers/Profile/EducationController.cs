using Espl.Linkup.Domain.Classes;
using Espl.Linkup.Domain.Profile.Education;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Espl.Linkup.Web.Controllers.Profile
{
    public class EducationController : ApiController
    {
        static List<Education> educationList = new List<Education>();
        // GET: api/Education
        public IHttpActionResult Get()
        {

            educationList.Add(
                new Education
                {
                    Class = new Class { ID = 1, Name = "Post Graduation" },
                    Degree = "MCA",
                    Grade = "First Class",
                    Percentage = "70%",
                    YearOfPassing = "2012",
                    Status = "Approved",
                    Comments = "Great"
                }
                );

            educationList.Add(
                new Education
                {
                    ID=1,
                    Class = new Class { ID = 1, Name = "Graduation" },
                    Degree = "BSC Computer Science",
                    Grade = "First Class",
                    Percentage = "60%",
                    YearOfPassing = "2009",
                    Status = "Approved",
                    Comments = "Great"
                }
                );

            return Ok(educationList);
        }

        // GET: api/Education/5
        public IHttpActionResult Get(int id)
        {
            var result = educationList.Where(p => p.ID == id).FirstOrDefault();
            return Ok(result);
        }

        // POST: api/Education
        public IHttpActionResult Post(Education value)
        {
            educationList.Add(value);
            value.ID = educationList.Count;
            return Ok(value);
        }

        // PUT: api/Education/5
        public IHttpActionResult Put(int id, Education value)
        {
            Education result = educationList.Where(p => p.ID == id).FirstOrDefault();
            result.Class = value.Class;
            result.Degree = value.Degree;
            result.Grade = value.Grade;
            result.Percentage = value.Percentage;
            result.YearOfPassing = value.YearOfPassing;
            result.Status = value.Status;
            result.Comments = value.Comments;
            result.Status = value.Status;
            result.Comments = value.Comments;
            return Ok(result);
        }

        // DELETE: api/Education/5
        public IHttpActionResult Delete(int id)
        {
            Education result = educationList.Where(p => p.ID == id).FirstOrDefault();
            var resultflag = educationList.Remove(result);
            return Ok(resultflag);
        }
    }
}
