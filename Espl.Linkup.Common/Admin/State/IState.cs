using Espl.Linkup.Common.Core;
using Espl.Linkup.Common.Countries;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Espl.Linkup.Common.States
{
    public interface IState : IBaseEntity<IState, IStateSearch>
    {
        #region Properties
        //
        string Name { get; set; }
        ICountry Country { get; set; }
        #endregion Properties
    }
}
