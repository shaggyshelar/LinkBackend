using Espl.Linkup.Common.Core;
using Espl.Linkup.Common.Employee;
using Espl.Linkup.Common.SkillTypes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Espl.Linkup.Common.Skill
{
    public interface ISkill : IBaseEntity<ISkill, ISkillSearch>
    {
        #region Properties
        //
        string Description { get; set; }
        ISkillType Type { get; set; }
        IList<IEmployee> Approvers { get; set; }
        string Status { get; set; }
        string Comments { get; set; }

        #endregion Properties
    }
}
