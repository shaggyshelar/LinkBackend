using Espl.Linkup.Common.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Espl.Linkup.Common.Certifications
{
    public interface ICertification : IBaseEntity<ICertification, ICertificationSearch>
    {
        #region Properties
        //
        string Name { get; set; }
        string Code { get; set; }
        bool FromESPL { get; set; }
        DateTime Date { get; set; }
        DateTime ExpiryDate { get; set; }
        string FilePath { get; set; }

        string Status { get; set; }
        string Comments { get; set; }

        #endregion Properties
    }
}
