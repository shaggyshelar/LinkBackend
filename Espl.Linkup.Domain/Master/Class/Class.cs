
using Espl.Linkup.Common.Classes;
using Espl.Linkup.Domain.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Espl.Linkup.Domain.Classes
{

    public class Class : BaseEntity<IClass, IClassSearch>,IClass
    {

        protected override IBaseDao<IClass, IClassSearch> GetDAO()
        {
            //return DaoFactoryProvider.CreateInstance().GetDao<IClassDAO>();
            throw new NotImplementedException();
        }

        public string Name { get; set; }
    }
}
