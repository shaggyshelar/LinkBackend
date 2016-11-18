using Espl.Linkup.Common.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Espl.Linkup.Common.Certification
{
    public interface ICertification : IBaseEntity<ICertification, ICertificationSearch>
    {
        #region Properties
        //
        string CertificationName { get; set; }
        string CertificationCode { get; set; }
        bool FromESPL { get; set; }
        DateTime CertificationDate { get; set; }
        string CertificationDoc { get; set; }
        string Status { get; set; }
        string Comments { get; set; }

        #endregion Properties
    }
}
