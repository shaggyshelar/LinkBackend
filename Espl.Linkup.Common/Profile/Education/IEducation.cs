using Espl.Linkup.Common.Classes;
using Espl.Linkup.Common.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Espl.Linkup.Common.Education
{
    public interface IEducation : IBaseEntity<IEducation, IEducationSearch>
    {
        #region Properties
        //
        IClass Class { get; set; }
        string Degree { get; set; }
        string Grade { get; set; }
        string Percentage { get; set; }
        string YearOfPassing { get; set; }
        string Status { get; set; }
        string Comments { get; set; }
        string FilePath { get; set; }

        #endregion Properties
    }
}
