using Espl.Linkup.Common.Leaves;
using Espl.Linkup.Common.Leaves.Approvers;
using Espl.Linkup.Common.Projects;
using Espl.Linkup.Domain.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Espl.Linkup.Domain.Leave.Approvers
{

    public class Approver : BaseEntity<IApprover, IApproverSearch>,IApprover
    {


        protected override IBaseDao<IApprover, IApproverSearch> GetDAO()
        {
            //return DaoFactoryProvider.CreateInstance().GetDao<IApproverDAO>();
            throw new NotImplementedException();
        }

        public ILeave Leave { get; set; }
        public IProject Project { get; set; }
        public bool Status { get; set; }
        public string Comments { get; set; }
    }
}
