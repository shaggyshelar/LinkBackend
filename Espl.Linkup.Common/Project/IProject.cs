using Espl.Linkup.Common.Core;
using Espl.Linkup.Common.Users;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Espl.Linkup.Common.Projects
{
    public interface IProject : IBaseEntity<IProject, IProjectSearch>
    {
        #region Properties
        //
        string Name { get; set; }
        IUser Manager { get; set; }
        #endregion Properties
    }
}
