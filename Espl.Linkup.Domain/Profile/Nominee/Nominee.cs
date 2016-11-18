using Espl.Linkup.Common.Nominee;
using Espl.Linkup.Domain.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Espl.Linkup.Domain.Profile.Nominee
{

    public class Nominee : BaseEntity<INominee, INomineeSearch>, INominee
    {

        protected override IBaseDao<INominee, INomineeSearch> GetDAO()
        {
            //return DaoFactoryProvider.CreateInstance().GetDao<INomineeDAO>();
            throw new NotImplementedException();
        }

        public string FirstNomineeName { get; set; }
        public string FirstNomineeRelationWithEmp { get; set; }
        public string SecondNomineeName { get; set; }
        public string SecondNomineeRelationWithEmp { get; set; }
    }
}
