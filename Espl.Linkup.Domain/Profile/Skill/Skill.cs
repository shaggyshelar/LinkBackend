using Espl.Linkup.Common.Skill;
using Espl.Linkup.Domain.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Espl.Linkup.Domain.Profile.Skill
{

    public class Skill : BaseEntity<ISkill, ISkillSearch>, ISkill
    {

        protected override IBaseDao<ISkill, ISkillSearch> GetDAO()
        {
            //return DaoFactoryProvider.CreateInstance().GetDao<ISkillDAO>();
            throw new NotImplementedException();
        }

        public string Skills { get; set; }
        public string SkillType { get; set; }
        public IList<string> Approvers { get; set; }
        public string Status { get; set; }
        public string Comments { get; set; }
    }
}
