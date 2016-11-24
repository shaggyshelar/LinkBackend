using Espl.Linkup.Common.Core;
using Espl.Linkup.Common.Users;
using Espl.Linkup.Common.Projects;
using Espl.Linkup.Common.Projects.Tasks;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Espl.Linkup.Common.Timesheets
{
    public interface ITimesheet : IBaseEntity<ITimesheet, ITimesheetSearch>
    {
        #region Properties
        //
        IProject Project { get; set; }
        ITask Task { get; set; }
        Int64 TimesheetGroupID { get; set; }
        string MondayBNote { get; set; }
        string TuesdayBNote { get; set; }
        string WednesdayBNote { get; set; }
        string ThursdayBNote { get; set; }
        string FridayBNote { get; set; }
        string SaturdayBNote { get; set; }
        string SundayBNote { get; set; }

        TimeSpan MondayBTime { get; set; }
        TimeSpan TuesdayBTime { get; set; }
        TimeSpan WednesdayBTime { get; set; }
        TimeSpan ThursdayBTime { get; set; }
        TimeSpan FridayBTime { get; set; }
        TimeSpan SaturdayBTime { get; set; }
        TimeSpan SundayBTime { get; set; }

        string MondayNBNote { get; set; }
        string TuesdayNBNote { get; set; }
        string WednesdayNBNote { get; set; }
        string ThursdayNBNote { get; set; }
        string FridayNBNote { get; set; }
        string SaturdayNBNote { get; set; }
        string SundayNBNote { get; set; }

        TimeSpan MondayNBTime { get; set; }
        TimeSpan TuesdayNBTime { get; set; }
        TimeSpan WednesdayNBTime { get; set; }
        TimeSpan ThursdayNBTime { get; set; }
        TimeSpan FridayNBTime { get; set; }
        TimeSpan SaturdayNBTime { get; set; }
        TimeSpan SundayNBTime { get; set; }

        DateTime MondayDate { get; set; }
        DateTime TuesdayDate { get; set; }
        DateTime WednesdayDate { get; set; }
        DateTime ThursdayDate { get; set; }
        DateTime FridayDate { get; set; }
        DateTime SaturdayDate { get; set; }
        DateTime SundayDate { get; set; }

        bool Status { get; set; }

        #endregion Properties
    }
}
