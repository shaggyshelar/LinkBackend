
using Espl.Linkup.Common.Countries;
using Espl.Linkup.Domain.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Espl.Linkup.Domain.Countries
{

    public class Country : BaseEntity<ICountry, ICountrySearch>,ICountry
    {

        protected override IBaseDao<ICountry, ICountrySearch> GetDAO()
        {
            //return DaoFactoryProvider.CreateInstance().GetDao<ICountryDAO>();
            throw new NotImplementedException();
        }

        public string Name { get; set; }
    }
}
