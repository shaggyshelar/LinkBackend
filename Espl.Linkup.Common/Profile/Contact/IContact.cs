using Espl.Linkup.Common.ContactTypes;
using Espl.Linkup.Common.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Espl.Linkup.Common.Contacts
{
    public interface IContact : IBaseEntity<IContact, IContactSearch>
    {
        #region Properties
        //
        string Name { get; set; }
        string Number { get; set; }
        IContactType Type { get; set; }
        #endregion Properties
    }
}
