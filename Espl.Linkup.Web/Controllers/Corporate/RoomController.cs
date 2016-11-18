using Espl.Linkup.Domain.Corporate.Rooms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Espl.Linkup.Web.Controllers.Corporate.Rooms
{
    public class RoomController : ApiController
    {
        // GET: api/Room
        static List<Room> roomList = new List<Room>();
        // GET: api/Room
        public IHttpActionResult Get()
        {

            roomList.Add(new Room
            {
                roomName = "First",
                ID = 1
            });
            roomList.Add(new Room
            {
                roomName = "Second",
                ID = 2
            });

            return Ok(roomList);
        }

        // GET: api/Room/5
        public IHttpActionResult Get(int id)
        {
            var result = roomList.Where(p => p.ID == id).FirstOrDefault();
            return Ok(result);
        }

        // POST: api/Room
        public IHttpActionResult Post(Room value)
        {
            Room result = new Room();
            result.roomName = value.roomName;
            roomList.Add(result);
            result.ID = roomList.Count;
            return Ok(result.ID);
        }

        // PUT: api/Room/5
        public IHttpActionResult Put(int id, Room value)
        {
            Room result = roomList.Where(p => p.ID == id).FirstOrDefault();
            result.roomName = value.roomName;
            return Ok(result);
        }

        // DELETE: api/Room/5
        public IHttpActionResult Delete(int id)
        {
            Room result = roomList.Where(p => p.ID == id).FirstOrDefault();
            var resultflag = roomList.Remove(result);
            return Ok(resultflag);
        }
    }
}
