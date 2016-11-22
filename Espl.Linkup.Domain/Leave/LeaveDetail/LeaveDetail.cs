using Espl.Linkup.Common.Leave.LeaveDetail;
using Espl.Linkup.Domain.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Espl.Linkup.Domain.Leaves.LeaveDetail
{

    public class LeaveDetail : BaseEntity<ILeaveDetail, ILeaveDetailSearch>,ILeaveDetail
    {


        protected override IBaseDao<ILeaveDetail, ILeaveDetailSearch> GetDAO()
        {
            //return DaoFactoryProvider.CreateInstance().GetDao<ILeaveDetailDAO>();
            throw new NotImplementedException();
        }



        public IList<Common.Leaves.ILeave> Leavelst { get; set; }

        public int NumberOfLeave { get; set; }

        public int HalfDayLeave { get; set; }

        public int Absent { get; set; }

        public int HalfDayAbsent { get; set; }
    }
}
