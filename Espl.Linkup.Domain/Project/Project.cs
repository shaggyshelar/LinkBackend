using Espl.Linkup.Common.Projects;
using Espl.Linkup.Domain.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Espl.Linkup.Domain.Projects
{

    public class Project : BaseEntity<IProject, IProjectSearch>,IProject
    {

        protected override IBaseDao<IProject, IProjectSearch> GetDAO()
        {
            //return DaoFactoryProvider.CreateInstance().GetDao<IProjectDAO>();
            throw new NotImplementedException();
        }

        public string ProjectName { get; set; }
        public Common.Employee.IEmployee ProjectManager { get; set; }
    }
}
