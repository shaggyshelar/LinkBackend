using Espl.Linkup.Common.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Espl.Linkup.Common.Visa
{
    public interface IVisa : IBaseEntity<IVisa, IVisaSearch>
    {
        #region Properties
        //
        string VisaNumber { get; set; }
        DateTime ExpDate { get; set; }
        string VisaType { get; set; }
        string Status { get; set; }
        string Comments { get; set; }
        string VisaFilePath { get; set; }

        #endregion Properties
    }
}
