using Espl.Linkup.Common.Core;
using Espl.Linkup.Common.Users;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Espl.Linkup.Common.Projects.Tasks
{
    public interface ITask : IBaseEntity<ITask, ITaskSearch>
    {
        #region Properties
        //
        string Name { get; set; }
        IProject Project { get; set; }
        #endregion Properties
    }
}
