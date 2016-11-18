using Espl.Linkup.Common.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Espl.Linkup.Common.Employee
{
    public interface IEmployee : IBaseEntity<IEmployee, IEmployeeSearch>
    {
        #region Properties
        //
        string Name { get; set; }
        DateTime DOB { get; set; }
        string ContactNo { get; set; }
        string CurrentAdd { get; set; }
        string Email { get; set; }
        string ESPL_PF_No { get; set; }
        string PreviousPFNo { get; set; }
        DateTime CareerStartDate { get; set; }
        DateTime LastWorkingDayOfPrevEmployer { get; set; }
        string EmergencyContactNumber { get; set; }
        string EmergencyContactName { get; set; }
        string BloodGroup { get; set; }
        string SkypeID { get; set; }
        string ProfilePath { get; set; }

        #endregion Properties
    }
}
