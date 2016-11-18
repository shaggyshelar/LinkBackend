using Espl.Linkup.Common.Core;
using Espl.Linkup.Common.Leaves;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Espl.Linkup.Common.Leave.LeaveDetail
{
    public interface ILeaveDetail : IBaseEntity<ILeaveDetail, ILeaveDetailSearch>
    {
        #region Properties
        //
        IList<ILeave> Leavelst {get;set;}
        Int32 NumberOfLeave { get; set; }
        Int32 HalfDayLeave { get; set; }
        Int32 Absent { get; set; }
        Int32 HalfDayAbsent { get; set; }
        #endregion Properties
    }
}
