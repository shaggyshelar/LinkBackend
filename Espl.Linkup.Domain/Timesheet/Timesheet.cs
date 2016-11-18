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

    public class Timesheet : BaseEntity<ITimesheet, ITimesheetSearch>,ITimesheet
    {

        protected override IBaseDao<ITimesheet, ITimesheetSearch> GetDAO()
        {
            //return DaoFactoryProvider.CreateInstance().GetDao<ITimesheetDAO>();
            throw new NotImplementedException();
        }

        public IProject project { get; set; }
        public ITask task { get; set; }
        public long timesheetGroupID { get; set; }
        public string monday_b_note { get; set; }
        public string tuesday_b_note { get; set; }
        public string wednesday_b_note { get; set; }
        public string thursday_b_note { get; set; }
        public string friday_b_note { get; set; }
        public string saturday_b_note { get; set; }
        public string sunday_b_note { get; set; }
        public TimeSpan monday_b_time { get; set; }
        public TimeSpan tuesday_b_time { get; set; }
        public TimeSpan wednesday_b_time { get; set; }
        public TimeSpan thursday_b_time { get; set; }
        public TimeSpan friday_b_time { get; set; }
        public TimeSpan saturday_b_time { get; set; }
        public TimeSpan sunday_b_time { get; set; }
        public string monday_nb_note { get; set; }
        public string tuesday_nb_note { get; set; }
        public string wednesday_nb_note { get; set; }
        public string thursday_nb_note { get; set; }
        public string friday_nb_note { get; set; }
        public string saturday_nb_note { get; set; }
        public string sunday_nb_note { get; set; }
        public TimeSpan monday_nb_time { get; set; }
        public TimeSpan tuesday_nb_time { get; set; }
        public TimeSpan wednesday_nb_time { get; set; }
        public TimeSpan thursday_nb_time { get; set; }
        public TimeSpan friday_nb_time { get; set; }
        public TimeSpan saturday_nb_time { get; set; }
        public TimeSpan sunday_nb_time { get; set; }
        public DateTime monday_dt { get; set; }
        public DateTime tuesday_dt { get; set; }
        public DateTime wednesday_dt { get; set; }
        public DateTime thursday_dt { get; set; }
        public DateTime friday_dt { get; set; }
        public DateTime saturday_dt { get; set; }
        public DateTime sunday_dt { get; set; }
        public bool status { get; set; }
    }
}
