using Espl.Linkup.Common.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Espl.Linkup.Common.IDProof
{
    public interface IIDProof : IBaseEntity<IIDProof, IIDProofSearch>
    {
        #region Properties
        //
    
        string IDProofType { get; set; }
        string Value { get; set; }
        string Status { get; set; }
        string Comments { get; set; }
        string IDProofFilePath { get; set; }

        #endregion Properties
    }
}
