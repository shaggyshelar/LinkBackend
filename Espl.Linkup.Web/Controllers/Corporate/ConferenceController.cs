using Espl.Linkup.Common.Corporate.Treatments;
using Espl.Linkup.Common.Employee;
using Espl.Linkup.Domain.Corporate.Conferences;
using Espl.Linkup.Domain.Corporate.Treatments;
using Espl.Linkup.Domain.Profile.Employee;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Espl.Linkup.Web.Controllers.Corporate
{
    public class ConferenceController : ApiController
    {
        // GET: api/Conference
        static List<Conference> conferenceList = new List<Conference>();
        // GET: api/Conference
        public IHttpActionResult Get()
        {
            List<IEmployee> empList = new List<IEmployee>();
            empList.Add(new Employee { Name = "Amol", ID = 1 });
            empList.Add(new Employee { Name = "Ganesh", ID = 2 });

            List<ITreatment> teatmentList = new List<ITreatment>();
            teatmentList.Add(new Treatment { TreatmentName = "Tea", ID = 1 });
            teatmentList.Add(new Treatment { TreatmentName = "Water", ID = 2 });


            conferenceList.Add(new Conference
            {
                ID = 1,
                Title = "Project Meeting",
                IsDeleted = false,
                Description = "This is Project Status Metting",
                EndTime = new DateTime(2016, 11, 11, 15, 00, 00),
                StartTime = new DateTime(2016, 11, 11, 45, 00, 00),
                SpecialComments = "This is Special Comments",
                Attendees = empList,
                SpecialTreatment = teatmentList
            });
            conferenceList.Add(new Conference
            {
                Title = "Project Meeting",
                IsDeleted = false,
                Description = "This is Project Status Metting",
                EndTime = new DateTime(2016, 11, 11, 15, 00, 00),
                StartTime = new DateTime(2016, 11, 11, 45, 00, 00),
                SpecialComments = "This is Special Comments",
                Attendees = empList,
                SpecialTreatment = teatmentList,
                ID = 2
            });
            return Ok(conferenceList);
        }

        // GET: api/Conference/5
        public IHttpActionResult Get(int id)
        {
            var result = conferenceList.Where(p => p.ID == id).FirstOrDefault();
            return Ok(result);
        }

        // POST: api/Conference
        public IHttpActionResult Post(Conference value)
        {
            conferenceList.Add(value);
            value.ID = conferenceList.Count;
            return Ok(value.ID);
        }

        // PUT: api/Conference/5
        public IHttpActionResult Put(int id, Conference value)
        {
            Conference result = conferenceList.Where(p => p.ID == id).FirstOrDefault();
            result = value;
            return Ok(result);
        }

        // DELETE: api/Conference/5
        public IHttpActionResult Delete(int id)
        {
            Conference result = conferenceList.Where(p => p.ID == id).FirstOrDefault();
            var resultflag = conferenceList.Remove(result);
            return Ok(resultflag);
        }
    }
}
