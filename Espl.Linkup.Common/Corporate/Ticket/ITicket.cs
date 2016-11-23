using Espl.Linkup.Common.Core;
using Espl.Linkup.Common.Departments;
using Espl.Linkup.Common.Employee;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Espl.Linkup.Common.Corporate.Ticket
{
    public interface ITicket : IBaseEntity<ITicket, ITicketSearch>
    {
        #region Properties
        //
        IDepartment Department { get; set; }
        DateTime HolidayDate { get; set; }
        Enum Priority { get; set; }
        string Concern { get; set; }
        string Description { get; set; }
        IEmployee ResolvedBy { get; set; }
        bool Isclosed { get; set; }
        bool IsReopen { get; set; }
        string Status { get; set; }
        #endregion Properties
    }
}
