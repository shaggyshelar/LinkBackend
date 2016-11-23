using Espl.Linkup.Common.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Espl.Linkup.Common.SkillTypes
{
    public interface ISkillType : IBaseEntity<ISkillType, ISkillTypeSearch>
    {
        #region Properties
        //
        string Name { get; set; }

        #endregion Properties
    }
}
