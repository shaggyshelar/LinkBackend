using Espl.Linkup.Common.Roles;
using Espl.Linkup.Domain.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Espl.Linkup.Domain.Roles
{

    public class Role : BaseEntity<IRole, IRoleSearch>,IRole
    {

        protected override IBaseDao<IRole, IRoleSearch> GetDAO()
        {
            //return DaoFactoryProvider.CreateInstance().GetDao<IRoleDAO>();
            throw new NotImplementedException();
        }

        public string Name { get; set; }
    }
}
