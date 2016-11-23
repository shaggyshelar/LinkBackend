using Espl.Linkup.Common.Certifications;
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

        public string Name { get; set; }
        public string Code { get; set; }
        public bool FromESPL { get; set; }
        public DateTime Date { get; set; }
        public DateTime ExpiryDate { get; set; }
        public string FilePath { get; set; }
        public string Status { get; set; }
        public string Comments { get; set; }
    }
}
