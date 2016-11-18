using Espl.Linkup.Common.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Espl.Linkup.Common.EmploymentHistory
{
    public interface IEmploymentHistory : IBaseEntity<IEmploymentHistory, IEmploymentHistorySearch>
    {
        #region Properties
        //
        string EmploymentDetail { get; set; }
        DateTime StartDate { get; set; }
        DateTime EndDate { get; set; }
        string Duration { get; set; }
        string Designation { get; set; }
        string Status { get; set; }
        string Comments { get; set; }

        string FirstMonthSalarySlip { get; set; }
        string SecondMonthSalarySlip { get; set; }
        string ThirdMonthSalarySlip { get; set; }
        string FirstEmployerRelieving { get; set; }
        string SecondEmployerRelieving { get; set; }

        #endregion Properties
    }
}
