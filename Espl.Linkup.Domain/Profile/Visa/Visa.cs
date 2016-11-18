using Espl.Linkup.Common.Visa;
using Espl.Linkup.Domain.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Espl.Linkup.Domain.Profile.Visa
{

    public class Visa : BaseEntity<IVisa, IVisaSearch>, IVisa
    {

        protected override IBaseDao<IVisa, IVisaSearch> GetDAO()
        {
            //return DaoFactoryProvider.CreateInstance().GetDao<IVisaDAO>();
            throw new NotImplementedException();
        }

        public string Status { get; set; }
        public string Comments { get; set; }
        public string VisaNumber { get; set; }
        public DateTime ExpDate { get; set; }
        public string VisaType { get; set; }
        public string VisaFilePath { get; set; }
    }
}
