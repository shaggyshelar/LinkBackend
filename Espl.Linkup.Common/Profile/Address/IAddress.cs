using Espl.Linkup.Common.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Espl.Linkup.Common.Address
{
    public interface IAddress : IBaseEntity<IAddress, IAddressSearch>
    {
        #region Properties
        //
        string CurrentAdd { get; set; }
        string CurrentAddFilePath { get; set; }
        string PermanantAdd { get; set; }
        string PermanantAddFilePath { get; set; }
        string Status { get; set; }
        string Comments { get; set; }

        #endregion Properties
    }
}
