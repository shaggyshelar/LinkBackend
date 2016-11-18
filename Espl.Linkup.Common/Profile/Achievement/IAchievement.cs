using Espl.Linkup.Common.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Espl.Linkup.Common.Achievement
{
    public interface IAchievement : IBaseEntity<IAchievement, IAchievementSearch>
    {
        #region Properties
        //
        string AchievementName { get; set; }
        string Status { get; set; }
        string Comments { get; set; }

        #endregion Properties
    }
}
