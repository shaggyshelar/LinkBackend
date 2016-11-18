using Espl.Linkup.Common.Address;
using Espl.Linkup.Domain.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Espl.Linkup.Domain.Profile.Address
{

    public class Address : BaseEntity<IAddress, IAddressSearch>, IAddress
    {

        protected override IBaseDao<IAddress, IAddressSearch> GetDAO()
        {
            //return DaoFactoryProvider.CreateInstance().GetDao<IAddressDAO>();
            throw new NotImplementedException();
        }


        public string CurrentAdd { get; set; }
        public string CurrentAddFilePath { get; set; }
        public string PermanantAdd { get; set; }
        public string PermanantAddFilePath { get; set; }
    }
}
