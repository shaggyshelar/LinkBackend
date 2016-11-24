using Espl.Linkup.Common.Features;
using Espl.Linkup.Domain.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Espl.Linkup.Domain.Features
{

    public class Feature : BaseEntity<IFeature, IFeatureSearch>,IFeature
    {

        protected override IBaseDao<IFeature, IFeatureSearch> GetDAO()
        {
            //return DaoFactoryProvider.CreateInstance().GetDao<IFeatureDAO>();
            throw new NotImplementedException();
        }

        public string Name { get; set; }
    }
}
