﻿
using Espl.Linkup.Common.Leaves;
using Espl.Linkup.Common.Leaves.Approvers;
using Espl.Linkup.Domain.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Espl.Linkup.Domain.Leaves
{

    public class Leave : BaseEntity<ILeave, ILeaveSearch>, ILeave
    {

        protected override IBaseDao<ILeave, ILeaveSearch> GetDAO()
        {
            //return DaoFactoryProvider.CreateInstance().GetDao<ILeaveDAO>();
            throw new NotImplementedException();
        }

        public IList<IApprover> Approvers { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public long NumberOfLeave { get; set; }
        public string Status { get; set; }
        public string Reason { get; set; }

    }
}
