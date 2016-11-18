using Espl.Linkup.Domain.Projects;
using Espl.Linkup.Domain.Projects.Tasks;
using Espl.Linkup.Domain.Timesheets;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Espl.Linkup.Web.Controllers.Timesheets
{
    public class TimesheetController : ApiController
    {
        static List<Timesheet> timesheetList = new List<Timesheet>();
        // GET: api/Timesheet
        public IHttpActionResult Get()
        {

            timesheetList.Add(new Timesheet
            {
                project = new Project { ID = 1, ProjectName = "First" },
                task = new Task { ID = 1, TaskName = "Development" },
                timesheetGroupID = 1,
                monday_b_note = "This is sample task for project",
                tuesday_b_note = "This is sample task for project",
                wednesday_b_note = "This is sample task for project",
                thursday_b_note = "This is sample task for project",
                friday_b_note = "This is sample task for project",
                saturday_b_note = "This is sample task for project",
                sunday_b_note = "This is sample task for project",
                monday_b_time = new TimeSpan(2, 14, 00),
                tuesday_b_time = new TimeSpan(2, 14, 00),
                wednesday_b_time = new TimeSpan(2, 14, 00),
                thursday_b_time = new TimeSpan(2, 14, 00),
                friday_b_time = new TimeSpan(2, 14, 00),
                saturday_b_time = new TimeSpan(2, 14, 00),
                sunday_b_time = new TimeSpan(2, 14, 00),
                monday_nb_note = "This is sample task for project",
                tuesday_nb_note = "This is sample task for project",
                wednesday_nb_note = "This is sample task for project",
                thursday_nb_note = "This is sample task for project",
                friday_nb_note = "This is sample task for project",
                saturday_nb_note = "This is sample task for project",
                sunday_nb_note = "This is sample task for project",
                monday_nb_time = new TimeSpan(2, 14, 00),
                tuesday_nb_time = new TimeSpan(2, 15, 00),
                wednesday_nb_time = new TimeSpan(2, 16, 00),
                thursday_nb_time = new TimeSpan(2, 17, 00),
                friday_nb_time = new TimeSpan(2, 18, 00),
                saturday_nb_time = new TimeSpan(2, 19, 00),
                sunday_nb_time = new TimeSpan(2, 20, 00),
                monday_dt = new DateTime(11, 14, 2016),
                tuesday_dt = new DateTime(11, 15, 2016),
                wednesday_dt = new DateTime(11, 16, 2016),
                thursday_dt = new DateTime(11, 17, 2016),
                friday_dt = new DateTime(11, 18, 2016),
                saturday_dt = new DateTime(11, 19, 2016),
                sunday_dt = new DateTime(11, 20, 2016),
                status = false,
                ID = 1
            });
            timesheetList.Add(new Timesheet
            {
                project = new Project { ID = 2, ProjectName = "Second" },
                task = new Task { ID = 1, TaskName = "Development" },
                timesheetGroupID = 1,
                monday_b_note = "This is sample task for project",
                tuesday_b_note = "This is sample task for project",
                wednesday_b_note = "This is sample task for project",
                thursday_b_note = "This is sample task for project",
                friday_b_note = "This is sample task for project",
                saturday_b_note = "This is sample task for project",
                sunday_b_note = "This is sample task for project",
                monday_b_time = new TimeSpan(2, 14, 00),
                tuesday_b_time = new TimeSpan(2, 14, 00),
                wednesday_b_time = new TimeSpan(2, 14, 00),
                thursday_b_time = new TimeSpan(2, 14, 00),
                friday_b_time = new TimeSpan(2, 14, 00),
                saturday_b_time = new TimeSpan(2, 14, 00),
                sunday_b_time = new TimeSpan(2, 14, 00),
                monday_nb_note = "This is sample task for project",
                tuesday_nb_note = "This is sample task for project",
                wednesday_nb_note = "This is sample task for project",
                thursday_nb_note = "This is sample task for project",
                friday_nb_note = "This is sample task for project",
                saturday_nb_note = "This is sample task for project",
                sunday_nb_note = "This is sample task for project",
                monday_nb_time = new TimeSpan(2, 14, 00),
                tuesday_nb_time = new TimeSpan(2, 15, 00),
                wednesday_nb_time = new TimeSpan(2, 16, 00),
                thursday_nb_time = new TimeSpan(2, 17, 00),
                friday_nb_time = new TimeSpan(2, 18, 00),
                saturday_nb_time = new TimeSpan(2, 19, 00),
                sunday_nb_time = new TimeSpan(2, 20, 00),
                monday_dt = new DateTime(11, 14, 2016),
                tuesday_dt = new DateTime(11, 15, 2016),
                wednesday_dt = new DateTime(11, 16, 2016),
                thursday_dt = new DateTime(11, 17, 2016),
                friday_dt = new DateTime(11, 18, 2016),
                saturday_dt = new DateTime(11, 19, 2016),
                sunday_dt = new DateTime(11, 20, 2016),
                status = false,
                ID = 2
            });

            return Ok(timesheetList);
        }

        // GET: api/Timesheet/5
        public IHttpActionResult Get(int id)
        {
            var result = timesheetList.Where(p => p.ID == id).FirstOrDefault();
            return Ok(result);
        }

        // POST: api/Timesheet
        public IHttpActionResult Post(Timesheet value)
        {
            Timesheet result = new Timesheet();
            timesheetList.Add(result);
            result.ID = timesheetList.Count;
            return Ok(result.ID);
        }

        // PUT: api/Timesheet/5
        public IHttpActionResult Put(int id, Timesheet value)
        {
            Timesheet result = timesheetList.Where(p => p.ID == id).FirstOrDefault();
            result.project = value.project;
            result.task = value.task;
            result.timesheetGroupID = value.timesheetGroupID;
            result.monday_b_note = value.monday_b_note;
            result.tuesday_b_note = value.tuesday_b_note;
            result.wednesday_b_note = value.wednesday_b_note;
            result.thursday_b_note = value.thursday_b_note;
            result.friday_b_note = value.friday_b_note;
            result.saturday_b_note = value.saturday_b_note;
            result.sunday_b_note = value.sunday_b_note;
            result.monday_b_time = value.monday_b_time;
            result.tuesday_b_time = value.tuesday_b_time;
            result.wednesday_b_time = value.wednesday_b_time;
            result.thursday_b_time = value.thursday_b_time;
            result.friday_b_time = value.friday_b_time;
            result.saturday_b_time = value.saturday_b_time;
            result.sunday_b_time = value.sunday_b_time;
            result.monday_nb_note = value.monday_nb_note;
            result.tuesday_nb_note = value.tuesday_nb_note;
            result.wednesday_nb_note = value.wednesday_nb_note;
            result.thursday_nb_note = value.thursday_nb_note;
            result.friday_nb_note = value.friday_nb_note;
            result.saturday_nb_note = value.saturday_nb_note;
            result.sunday_nb_note = value.sunday_nb_note;
            result.monday_nb_time = value.monday_nb_time;
            result.tuesday_nb_time = value.tuesday_nb_time;
            result.wednesday_nb_time = value.wednesday_nb_time;
            result.thursday_nb_time = value.thursday_nb_time;
            result.friday_nb_time = value.friday_nb_time;
            result.saturday_nb_time = value.saturday_nb_time;
            result.sunday_nb_time = value.sunday_nb_time;
            result.monday_dt = value.monday_dt;
            result.tuesday_dt = value.tuesday_dt;
            result.wednesday_dt = value.wednesday_dt;
            result.thursday_dt = value.thursday_dt;
            result.friday_dt = value.friday_dt;
            result.saturday_dt = value.saturday_dt;
            result.sunday_dt = value.sunday_dt;
            result.status = value.status;
            return Ok(result);
        }

        // DELETE: api/Timesheet/5
        public IHttpActionResult Delete(int id)
        {
            Timesheet result = timesheetList.Where(p => p.ID == id).FirstOrDefault();
            var resultflag = timesheetList.Remove(result);
            return Ok(resultflag);
        }
    }
}
