using Espl.Linkup.Common.Projects;
using Espl.Linkup.Common.Projects.Tasks;
using Espl.Linkup.Domain.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Espl.Linkup.Domain.Projects.Tasks
{

    public class Task : BaseEntity<ITask, ITaskSearch>,ITask
    {

        protected override IBaseDao<ITask, ITaskSearch> GetDAO()
        {
            //return DaoFactoryProvider.CreateInstance().GetDao<ITaskDAO>();
            throw new NotImplementedException();
        }

        public string TaskName { get; set; }
        public IProject Project { get; set; }
    }
}
