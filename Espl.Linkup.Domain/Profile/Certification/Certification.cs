using Espl.Linkup.Common.Certification;
using Espl.Linkup.Domain.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Espl.Linkup.Domain.Profile.Certification
{

    public class Certification : BaseEntity<ICertification, ICertificationSearch>, ICertification
    {

        protected override IBaseDao<ICertification, ICertificationSearch> GetDAO()
        {
            //return DaoFactoryProvider.CreateInstance().GetDao<ICertificationDAO>();
            throw new NotImplementedException();
        }

        public string CertificationName { get; set; }
        public string CertificationCode { get; set; }
        public bool FromESPL { get; set; }
        public DateTime CertificationDate { get; set; }
        public string CertificationDoc { get; set; }
        public string Status { get; set; }
        public string Comments { get; set; }
    }
}
