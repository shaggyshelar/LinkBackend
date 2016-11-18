
using Espl.Linkup.Common.Corporate.Rooms;
using Espl.Linkup.Domain.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Espl.Linkup.Domain.Corporate.Rooms
{

    public class Room : BaseEntity<IRoom, IRoomSearch>,IRoom
    {

        protected override IBaseDao<IRoom, IRoomSearch> GetDAO()
        {
            //return DaoFactoryProvider.CreateInstance().GetDao<IRoomDAO>();
            throw new NotImplementedException();
        }



        public string roomName { get; set; }
    }
}
