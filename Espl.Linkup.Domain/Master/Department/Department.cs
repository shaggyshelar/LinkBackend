using Espl.Linkup.Common.Departments;
using Espl.Linkup.Domain.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Espl.Linkup.Domain.Departments
{

    public class Department : BaseEntity<IDepartment, IDepartmentSearch>,IDepartment
    {

        protected override IBaseDao<IDepartment, IDepartmentSearch> GetDAO()
        {
            //return DaoFactoryProvider.CreateInstance().GetDao<IDepartmentDAO>();
            throw new NotImplementedException();
        }

        public string Name { get; set; }
    }
}
