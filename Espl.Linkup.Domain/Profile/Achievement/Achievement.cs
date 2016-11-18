using Espl.Linkup.Common.Achievement;
using Espl.Linkup.Domain.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Espl.Linkup.Domain.Profile.Achievement
{

    public class Achievement : BaseEntity<IAchievement, IAchievementSearch>, IAchievement
    {

        protected override IBaseDao<IAchievement, IAchievementSearch> GetDAO()
        {
            //return DaoFactoryProvider.CreateInstance().GetDao<IAchievementDAO>();
            throw new NotImplementedException();
        }

        public string AchievementName { get; set; }
        public string Status { get; set; }
        public string Comments { get; set; }
    }
}
