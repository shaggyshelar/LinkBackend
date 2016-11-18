using Espl.Linkup.Common.Leaves.Holiday;
using Espl.Linkup.Domain.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Espl.Linkup.Domain.Leave.Holiday
{

    public class Holiday : BaseEntity<IHoliday, IHolidaySearch>,IHoliday
    {
        public string Title { get; set; }
        public DateTime HolidayDate { get; set; }
        public string WeekDay { get; set; }
        public string HolidayType { get; set; }

        protected override IBaseDao<IHoliday, IHolidaySearch> GetDAO()
        {
            //return DaoFactoryProvider.CreateInstance().GetDao<IHolidayDAO>();
            throw new NotImplementedException();
        }


    }
}
