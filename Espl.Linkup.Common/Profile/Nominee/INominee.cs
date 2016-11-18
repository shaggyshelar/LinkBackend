using Espl.Linkup.Common.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Espl.Linkup.Common.Nominee
{
    public interface INominee : IBaseEntity<INominee, INomineeSearch>
    {
        #region Properties
        //
        string FirstNomineeName { get; set; }
        string FirstNomineeRelationWithEmp { get; set; }
        string SecondNomineeName { get; set; }
        string SecondNomineeRelationWithEmp { get; set; }

        #endregion Properties
    }
}
