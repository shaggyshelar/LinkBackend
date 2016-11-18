using Espl.Linkup.Common.Core;
using Espl.Linkup.Common.Employee;
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
        IProject project { get; set; }
        ITask task { get; set; }
        Int64 timesheetGroupID { get; set; }
        string monday_b_note { get; set; }
        string tuesday_b_note { get; set; }
        string wednesday_b_note { get; set; }
        string thursday_b_note { get; set; }
        string friday_b_note { get; set; }
        string saturday_b_note { get; set; }
        string sunday_b_note { get; set; }

        TimeSpan monday_b_time { get; set; }
        TimeSpan tuesday_b_time { get; set; }
        TimeSpan wednesday_b_time { get; set; }
        TimeSpan thursday_b_time { get; set; }
        TimeSpan friday_b_time { get; set; }
        TimeSpan saturday_b_time { get; set; }
        TimeSpan sunday_b_time { get; set; }

        string monday_nb_note { get; set; }
        string tuesday_nb_note { get; set; }
        string wednesday_nb_note { get; set; }
        string thursday_nb_note { get; set; }
        string friday_nb_note { get; set; }
        string saturday_nb_note { get; set; }
        string sunday_nb_note { get; set; }

        TimeSpan monday_nb_time { get; set; }
        TimeSpan tuesday_nb_time { get; set; }
        TimeSpan wednesday_nb_time { get; set; }
        TimeSpan thursday_nb_time { get; set; }
        TimeSpan friday_nb_time { get; set; }
        TimeSpan saturday_nb_time { get; set; }
        TimeSpan sunday_nb_time { get; set; }

        DateTime monday_dt { get; set; }
        DateTime tuesday_dt { get; set; }
        DateTime wednesday_dt { get; set; }
        DateTime thursday_dt { get; set; }
        DateTime friday_dt { get; set; }
        DateTime saturday_dt { get; set; }
        DateTime sunday_dt { get; set; }

        bool status { get; set; }

        #endregion Properties
    }
}
