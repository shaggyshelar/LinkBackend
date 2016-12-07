using Espl.Linkup.Common.Core;
using Espl.Linkup.Common.Projects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Espl.Linkup.Common.Leaves.Approvers
{
    public interface IApprover : IBaseEntity<IApprover, IApproverSearch>
    {
        #region Properties
        //
        ILeave Leave { get; set; }
        IProject Project { get; set; }
        bool Status { get; set; }
        string Comments { get; set; }

        #endregion Properties
    }
}
