using Espl.Linkup.Common.SkillTypes;
using Espl.Linkup.Domain.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Espl.Linkup.Domain.SkillTypes
{

    public class SkillType : BaseEntity<ISkillType, ISkillTypeSearch>,ISkillType
    {

        protected override IBaseDao<ISkillType, ISkillTypeSearch> GetDAO()
        {
            //return DaoFactoryProvider.CreateInstance().GetDao<ISkillTypeDAO>();
            throw new NotImplementedException();
        }

        public string Name { get; set; }
    }
}
