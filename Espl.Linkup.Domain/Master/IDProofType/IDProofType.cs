using Espl.Linkup.Common.IDProofTypes;
using Espl.Linkup.Domain.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Espl.Linkup.Domain.IDProofTypes
{

    public class IDProofType : BaseEntity<IIDProofType, IIDProofTypeSearch>,IIDProofType
    {

        protected override IBaseDao<IIDProofType, IIDProofTypeSearch> GetDAO()
        {
            //return DaoFactoryProvider.CreateInstance().GetDao<IIDProofTypeDAO>();
            throw new NotImplementedException();
        }

        public string Name { get; set; }
    }
}
