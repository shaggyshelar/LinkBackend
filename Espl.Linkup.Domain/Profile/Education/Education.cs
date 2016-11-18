using Espl.Linkup.Common.Education;
using Espl.Linkup.Domain.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Espl.Linkup.Domain.Profile.Education
{

    public class Education : BaseEntity<IEducation, IEducationSearch>, IEducation
    {

        protected override IBaseDao<IEducation, IEducationSearch> GetDAO()
        {
            //return DaoFactoryProvider.CreateInstance().GetDao<IEducationDAO>();
            throw new NotImplementedException();
        }



        public string Class { get; set; }
        public string Degree { get; set; }
        public string Grade { get; set; }
        public string Percentage { get; set; }
        public string YearOfPassing { get; set; }
        public string Status { get; set; }
        public string Comments { get; set; }
        public string Certificate { get; set; }
    }
}
