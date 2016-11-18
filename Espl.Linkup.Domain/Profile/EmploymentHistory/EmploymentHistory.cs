using Espl.Linkup.Common.EmploymentHistory;
using Espl.Linkup.Domain.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Espl.Linkup.Domain.Profile.EmploymentHistory
{

    public class EmploymentHistory : BaseEntity<IEmploymentHistory, IEmploymentHistorySearch>, IEmploymentHistory
    {

        protected override IBaseDao<IEmploymentHistory, IEmploymentHistorySearch> GetDAO()
        {
            //return DaoFactoryProvider.CreateInstance().GetDao<IEmploymentHistoryDAO>();
            throw new NotImplementedException();
        }

        public string EmploymentDetail { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public string Duration { get; set; }
        public string Designation { get; set; }
        public string FirstMonthSalarySlip { get; set; }
        public string SecondMonthSalarySlip { get; set; }
        public string ThirdMonthSalarySlip { get; set; }
        public string FirstEmployerRelieving { get; set; }
        public string SecondEmployerRelieving { get; set; }
        public string Comments { get; set; }
        public string Status { get; set; }
    }
}
