using Espl.Linkup.Common.IDProof;
using Espl.Linkup.Domain.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Espl.Linkup.Domain.Profile.IDProof
{

    public class IDProof : BaseEntity<IIDProof, IIDProofSearch>, IIDProof
    {

        protected override IBaseDao<IIDProof, IIDProofSearch> GetDAO()
        {
            //return DaoFactoryProvider.CreateInstance().GetDao<IIDProofDAO>();
            throw new NotImplementedException();
        }



        public string IDProofType { get; set; }
        public string Value { get; set; }
        public string Status { get; set; }
        public string Comments { get; set; }
        public string IDProofFilePath { get; set; }
    }
}
