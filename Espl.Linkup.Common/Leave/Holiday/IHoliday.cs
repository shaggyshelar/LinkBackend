using Espl.Linkup.Common.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Espl.Linkup.Common.Leaves.Holiday
{
    public interface IHoliday : IBaseEntity<IHoliday, IHolidaySearch>
    {
        #region Properties
        //
        string Title { get; set; }
        DateTime HolidayDate { get; set; }
        string WeekDay { get; set; }
        string HolidayType { get; set; }
        #endregion Properties
    }
}
