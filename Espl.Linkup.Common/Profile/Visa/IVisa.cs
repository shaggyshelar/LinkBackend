using Espl.Linkup.Common.Core;
using Espl.Linkup.Common.Countries;
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
        string Number { get; set; }
        DateTime ExpDate { get; set; }
        string Type { get; set; }
        string Status { get; set; }
        string Comments { get; set; }
        string FilePath { get; set; }
        ICountry Country { get; set; }

        #endregion Properties
    }
}
