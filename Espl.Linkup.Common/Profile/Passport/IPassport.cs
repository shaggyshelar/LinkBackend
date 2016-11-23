using Espl.Linkup.Common.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Espl.Linkup.Common.Passport
{
    public interface IPassport : IBaseEntity<IPassport, IPassportSearch>
    {
        #region Properties
        //
        string Number { get; set; }
        DateTime ExpDate { get; set; }
        DateTime IssueDate { get; set; }
        string Type { get; set; }
        string Status { get; set; }
        string Comments { get; set; }
        string FilePath { get; set; }

        #endregion Properties
    }
}
