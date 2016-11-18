using Espl.Linkup.Common.Employee;
using Espl.Linkup.Domain.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Espl.Linkup.Domain.Profile.Employee
{

    public class Employee : BaseEntity<IEmployee, IEmployeeSearch>, IEmployee
    {

        protected override IBaseDao<IEmployee, IEmployeeSearch> GetDAO()
        {
            //return DaoFactoryProvider.CreateInstance().GetDao<IEmployeeDAO>();
            throw new NotImplementedException();
        }



        public string Name { get; set; }
        public DateTime DOB { get; set; }
        public string ContactNo { get; set; }
        public string CurrentAdd { get; set; }
        public string Email { get; set; }
        public string ESPL_PF_No { get; set; }
        public string PreviousPFNo { get; set; }
        public DateTime CareerStartDate { get; set; }
        public DateTime LastWorkingDayOfPrevEmployer { get; set; }
        public string EmergencyContactNumber { get; set; }
        public string EmergencyContactName { get; set; }
        public string BloodGroup { get; set; }
        public string SkypeID { get; set; }
        public string ProfilePath { get; set; }
    }
}
