using Espl.Linkup.Common.Projects;
using Espl.Linkup.Common.Projects.Tasks;
using Espl.Linkup.Common.Timesheets;
using Espl.Linkup.Domain.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Espl.Linkup.Domain.Timesheets
{

    public class Timesheet : BaseEntity<ITimesheet, ITimesheetSearch>, ITimesheet
    {

        protected override IBaseDao<ITimesheet, ITimesheetSearch> GetDAO()
        {
            //return DaoFactoryProvider.CreateInstance().GetDao<ITimesheetDAO>();
            throw new NotImplementedException();
        }



        public IProject Project { get; set; }

        public ITask Task { get; set; }
        public long TimesheetGroupID { get; set; }
        public string MondayBNote { get; set; }
        public string TuesdayBNote { get; set; }
        public string WednesdayBNote { get; set; }
        public string ThursdayBNote { get; set; }
        public string FridayBNote { get; set; }
        public string SaturdayBNote { get; set; }
        public string SundayBNote { get; set; }
        public TimeSpan MondayBTime { get; set; }
        public TimeSpan TuesdayBTime { get; set; }
        public TimeSpan WednesdayBTime { get; set; }
        public TimeSpan ThursdayBTime { get; set; }
        public TimeSpan FridayBTime { get; set; }
        public TimeSpan SaturdayBTime { get; set; }
        public TimeSpan SundayBTime { get; set; }
        public string MondayNBNote { get; set; }
        public string TuesdayNBNote { get; set; }
        public string WednesdayNBNote { get; set; }
        public string ThursdayNBNote { get; set; }
        public string FridayNBNote { get; set; }
        public string SaturdayNBNote { get; set; }
        public string SundayNBNote { get; set; }
        public TimeSpan MondayNBTime { get; set; }
        public TimeSpan TuesdayNBTime { get; set; }
        public TimeSpan WednesdayNBTime { get; set; }
        public TimeSpan ThursdayNBTime { get; set; }
        public TimeSpan FridayNBTime { get; set; }
        public TimeSpan SaturdayNBTime { get; set; }
        public TimeSpan SundayNBTime { get; set; }
        public DateTime MondayDate { get; set; }
        public DateTime TuesdayDate { get; set; }
        public DateTime WednesdayDate { get; set; }
        public DateTime ThursdayDate { get; set; }
        public DateTime FridayDate { get; set; }
        public DateTime SaturdayDate { get; set; }
        public DateTime SundayDate { get; set; }
        public bool Status { get; set; }
    }
}
