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

        public string Number { get; set; }
        public DateTime ExpDate { get; set; }
        public DateTime IssueDate { get; set; }
        public string Type { get;set; }
        public string Status { get; set; }
        public string Comments { get; set; }
        public string FilePath { get; set; }
    }
}
