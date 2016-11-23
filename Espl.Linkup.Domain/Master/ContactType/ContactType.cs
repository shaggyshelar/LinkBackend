using Espl.Linkup.Common.ContactTypes;
using Espl.Linkup.Domain.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Espl.Linkup.Domain.ContactTypes
{

    public class ContactType : BaseEntity<IContactType, IContactTypeSearch>,IContactType
    {

        protected override IBaseDao<IContactType, IContactTypeSearch> GetDAO()
        {
            //return DaoFactoryProvider.CreateInstance().GetDao<IContactTypeDAO>();
            throw new NotImplementedException();
        }

        public string Name { get; set; }
    }
}
