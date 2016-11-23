using Espl.Linkup.Common.Clients;
using Espl.Linkup.Domain.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Espl.Linkup.Domain.Clients
{

    public class Client : BaseEntity<IClient, IClientSearch>,IClient
    {

        protected override IBaseDao<IClient, IClientSearch> GetDAO()
        {
            //return DaoFactoryProvider.CreateInstance().GetDao<IClientDAO>();
            throw new NotImplementedException();
        }

        public string Name { get; set; }
    }
}
