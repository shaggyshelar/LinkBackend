using Espl.Linkup.Common.Core;
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
        string Skills { get; set; }
        string SkillType { get; set; }
        IList<string> Approvers { get; set; }
        string Status { get; set; }
        string Comments { get; set; }

        #endregion Properties
    }
}
