using Espl.Linkup.Common.Core;
using Espl.Linkup.Common.Employee;
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
        string ProjectName { get; set; }
        IEmployee ProjectManager { get; set; }
        #endregion Properties
    }
}
