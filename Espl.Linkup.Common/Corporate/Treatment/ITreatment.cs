using Espl.Linkup.Common.Core;
using Espl.Linkup.Common.Employee;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Espl.Linkup.Common.Corporate.Treatments
{
    public interface ITreatment : IBaseEntity<ITreatment, ITreatmentSearch>
    {
        #region Properties
        //
        string TreatmentName { get; set; }

        #endregion Properties
    }
}
