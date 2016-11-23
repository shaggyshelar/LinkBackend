using Espl.Linkup.Common.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Espl.Linkup.Common.PFs
{
    public interface IPF : IBaseEntity<IPF, IPFSearch>
    {
        #region Properties
        //
        string CurrentOrgPFNumber { get; set; }
        string PreviousOrgPFNumber { get; set; }

        #endregion Properties
    }
}
