using Espl.Linkup.Common.Contacts;
using Espl.Linkup.Domain.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Espl.Linkup.Domain.Profile.Contact
{

    public class Contact : BaseEntity<IContact, IContactSearch>, IContact
    {

        protected override IBaseDao<IContact, IContactSearch> GetDAO()
        {
            //return DaoFactoryProvider.CreateInstance().GetDao<IContactDAO>();
            throw new NotImplementedException();
        }

        public string Name { get; set; }
        public string Number { get; set; }
        public Common.ContactTypes.IContactType Type { get; set; }
    }
}
