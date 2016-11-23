using Espl.Linkup.Common.Countries;
using Espl.Linkup.Common.States;
using Espl.Linkup.Domain.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Espl.Linkup.Domain.States
{

    public class State : BaseEntity<IState, IStateSearch>, IState
    {

        protected override IBaseDao<IState, IStateSearch> GetDAO()
        {
            //return DaoFactoryProvider.CreateInstance().GetDao<IStateDAO>();
            throw new NotImplementedException();
        }

        public string Name { get; set; }
        public ICountry Country { get; set; }
    }
}
