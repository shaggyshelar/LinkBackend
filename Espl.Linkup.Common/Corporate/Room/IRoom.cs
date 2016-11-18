using Espl.Linkup.Common.Core;
using Espl.Linkup.Common.Employee;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Espl.Linkup.Common.Corporate.Rooms
{
    public interface IRoom : IBaseEntity<IRoom, IRoomSearch>
    {
        #region Properties
        //
        string roomName { get; set; }
        #endregion Properties
    }
}
