using Espl.Linkup.Common.PFs;
using Espl.Linkup.Domain.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Espl.Linkup.Domain.PFs
{

    public class PF : BaseEntity<IPF, IPFSearch>,IPF
    {

        protected override IBaseDao<IPF, IPFSearch> GetDAO()
        {
            //return DaoFactoryProvider.CreateInstance().GetDao<IPFDAO>();
            throw new NotImplementedException();
        }

        public string CurrentOrgPFNumber { get; set; }
        public string PreviousOrgPFNumber { get; set; }
    }
}
