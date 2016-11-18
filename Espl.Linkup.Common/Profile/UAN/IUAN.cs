using Espl.Linkup.Common.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Espl.Linkup.Common.UAN
{
    public interface IUAN : IBaseEntity<IUAN, IUANSearch>
    {
        #region Properties
        //
        string UANNumber { get; set; }
        bool FromESPL { get; set; }
        string Status { get; set; }
        string Comments { get; set; }
        string UANFilePath { get; set; }

        #endregion Properties
    }
}
