using Espl.Linkup.Common.Users;
using Espl.Linkup.Common.Skill;
using Espl.Linkup.Common.SkillTypes;
using Espl.Linkup.Domain.Core;
using Espl.Linkup.Domain.SkillTypes;
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

        public string Description { get; set; }
        public ISkillType Type { get; set; }
        public IList<IUser> Approvers { get; set; }
        public string Status { get; set; }
        public string Comments { get; set; }
    }
}
