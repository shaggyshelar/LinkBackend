using Espl.Linkup.Common.Core;
using Espl.Linkup.Common.Users;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Espl.Linkup.Common.Leaves
{
    public interface ILeave : IBaseEntity<ILeave, ILeaveSearch>
    {
        #region Properties
        //
        IUser User { get; set; }
        DateTime StartDate { get; set; }
        DateTime EndDate { get; set; }
        Int64 NumberOfLeave { get; set; }
        string Status { get; set; }
        string Reason { get; set; }

        #endregion Properties
    }
}
