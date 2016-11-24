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
                Project = new Project { ID = 1, Name = "First" },
                Task = new Task { ID = 1, Project = new Project { ID = 1 }, Name = "Development" },
                TimesheetGroupID = 1,
                MondayBNote = "This is sample task for project",
                TuesdayBNote = "This is sample task for project",
                WednesdayBNote = "This is sample task for project",
                ThursdayBNote = "This is sample task for project",
                FridayBNote = "This is sample task for project",
                SaturdayBNote = "This is sample task for project",
                SundayBNote = "This is sample task for project",
                MondayBTime = new TimeSpan(2, 14, 00),
                TuesdayBTime = new TimeSpan(2, 14, 00),
                WednesdayBTime = new TimeSpan(2, 14, 00),
                ThursdayBTime = new TimeSpan(2, 14, 00),
                FridayBTime = new TimeSpan(2, 14, 00),
                SaturdayBTime = new TimeSpan(2, 14, 00),
                SundayBTime = new TimeSpan(2, 14, 00),
                MondayNBNote = "This is sample task for project",
                TuesdayNBNote = "This is sample task for project",
                WednesdayNBNote
                = "This is sample task for project",
                ThursdayNBNote = "This is sample task for project",
                FridayNBNote = "This is sample task for project",
                SaturdayNBNote = "This is sample task for project",
                SundayNBNote = "This is sample task for project",
                MondayNBTime = new TimeSpan(2, 14, 00),
                TuesdayNBTime = new TimeSpan(2, 15, 00),
                WednesdayNBTime = new TimeSpan(2, 16, 00),
                ThursdayNBTime = new TimeSpan(2, 17, 00),
                FridayNBTime = new TimeSpan(2, 18, 00),
                SaturdayNBTime = new TimeSpan(2, 19, 00),
                SundayNBTime = new TimeSpan(2, 20, 00),
                MondayDate = new DateTime(2016, 11, 14),
                TuesdayDate = new DateTime(2016, 11, 15),
                WednesdayDate = new DateTime(2016, 11, 16),
                ThursdayDate = new DateTime(2016, 11, 17),
                FridayDate = new DateTime(2016, 11, 18),
                SaturdayDate = new DateTime(2016, 11, 19),
                SundayDate = new DateTime(2016, 11, 20),
                Status = false,
                ID = 1
            });
            timesheetList.Add(new Timesheet
            {
                Project = new Project { ID = 2, Name = "Second" },
                Task = new Task { ID = 1, Project = new Project { ID = 1 }, Name = "Development" },
                TimesheetGroupID = 1,
                MondayBNote = "This is sample task for project",
                TuesdayBNote = "This is sample task for project",
                WednesdayBNote = "This is sample task for project",
                ThursdayBNote = "This is sample task for project",
                FridayBNote = "This is sample task for project",
                SaturdayBNote = "This is sample task for project",
                SundayBNote = "This is sample task for project",
                MondayBTime = new TimeSpan(2, 14, 00),
                TuesdayBTime = new TimeSpan(2, 14, 00),
                WednesdayBTime = new TimeSpan(2, 14, 00),
                ThursdayBTime = new TimeSpan(2, 14, 00),
                FridayBTime = new TimeSpan(2, 14, 00),
                SaturdayBTime = new TimeSpan(2, 14, 00),
                SundayBTime = new TimeSpan(2, 14, 00),
                MondayNBNote = "This is sample task for project",
                TuesdayNBNote = "This is sample task for project",
                WednesdayNBNote = "This is sample task for project",
                ThursdayNBNote = "This is sample task for project",
                FridayNBNote = "This is sample task for project",
                SaturdayNBNote = "This is sample task for project",
                SundayNBNote = "This is sample task for project",
                MondayNBTime = new TimeSpan(2, 14, 00),
                TuesdayNBTime = new TimeSpan(2, 15, 00),
                WednesdayNBTime = new TimeSpan(2, 16, 00),
                ThursdayNBTime = new TimeSpan(2, 17, 00),
                FridayNBTime = new TimeSpan(2, 18, 00),
                SaturdayNBTime = new TimeSpan(2, 19, 00),
                SundayNBTime = new TimeSpan(2, 20, 00),
                MondayDate = new DateTime(2016, 11, 14),
                TuesdayDate = new DateTime(2016, 11, 15),
                WednesdayDate = new DateTime(2016, 11, 16),
                ThursdayDate = new DateTime(2016, 11, 17),
                FridayDate = new DateTime(2016, 11, 18),
                SaturdayDate = new DateTime(2016, 11, 19),
                SundayDate = new DateTime(2016, 11, 20),
                Status = false,
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
            return Ok(result);
        }

        // PUT: api/Timesheet/5
        public IHttpActionResult Put(int id, Timesheet value)
        {
            Timesheet result = timesheetList.Where(p => p.ID == id).FirstOrDefault();
            result.Project = value.Project;
            result.Task = value.Task;
            result.TimesheetGroupID = value.TimesheetGroupID;
            result.MondayBNote = value.MondayBNote;
            result.TuesdayBNote = value.TuesdayBNote;
            result.WednesdayBNote = value.WednesdayBNote;
            result.ThursdayBNote = value.ThursdayBNote;
            result.FridayBNote = value.FridayBNote;
            result.SaturdayBNote = value.SaturdayBNote;
            result.SundayBNote = value.SundayBNote;
            result.MondayBNote = value.MondayBNote;
            result.TuesdayBNote = value.TuesdayBNote;
            result.WednesdayBNote = value.WednesdayBNote;
            result.ThursdayBTime = value.ThursdayBTime;
            result.FridayBTime = value.FridayBTime;
            result.SaturdayBTime = value.SaturdayBTime;
            result.SundayBTime = value.SundayBTime;
            result.MondayNBNote = value.MondayNBNote;
            result.TuesdayNBNote = value.TuesdayNBNote;
            result.WednesdayNBNote = value.WednesdayNBNote;
            result.ThursdayNBNote = value.ThursdayNBNote;
            result.FridayNBNote = value.FridayNBNote;
            result.SaturdayNBNote = value.SaturdayNBNote;
            result.SundayNBNote = value.SundayNBNote;
            result.MondayNBTime = value.MondayNBTime;
            result.TuesdayNBTime = value.TuesdayNBTime;
            result.WednesdayNBTime = value.WednesdayNBTime;
            result.ThursdayNBTime = value.ThursdayNBTime;
            result.FridayNBTime = value.FridayNBTime;
            result.SaturdayNBTime = value.SaturdayNBTime;
            result.SundayNBTime = value.SundayNBTime;
            result.MondayDate = value.MondayDate;
            result.TuesdayDate = value.TuesdayDate;
            result.WednesdayDate = value.WednesdayDate;
            result.ThursdayDate = value.ThursdayDate;
            result.FridayDate = value.FridayDate;
            result.SaturdayDate = value.SaturdayDate;
            result.SundayDate = value.SundayDate;
            result.Status = value.Status;
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
