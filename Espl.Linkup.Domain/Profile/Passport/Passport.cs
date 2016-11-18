using Espl.Linkup.Common.Passport;
using Espl.Linkup.Domain.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Espl.Linkup.Domain.Profile.Passport
{

    public class Passport : BaseEntity<IPassport, IPassportSearch>, IPassport
    {

        protected override IBaseDao<IPassport, IPassportSearch> GetDAO()
        {
            //return DaoFactoryProvider.CreateInstance().GetDao<IPassportDAO>();
            throw new NotImplementedException();
        }

        public string PassportNumber { get; set; }
        public DateTime ExpDate { get; set; }
        public string PassportType { get;set; }
        public string Status { get; set; }
        public string Comments { get; set; }
        public string PassportFilePath { get; set; }
    }
}
