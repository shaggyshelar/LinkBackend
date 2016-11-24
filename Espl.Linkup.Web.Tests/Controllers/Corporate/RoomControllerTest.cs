using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

using System.Web.Mvc;
using System.Collections.Generic;
using Espl.Linkup.Web.Controllers.Leaves;
using System.Web.Http.Results;
using Espl.Linkup.Web.Controllers.Corporate;
using Espl.Linkup.Domain.Corporate.Rooms;
using Espl.Linkup.Domain.Profile.Users;
using Espl.Linkup.Domain.Departments;
using Espl.Linkup.Web.Controllers.Corporate.Rooms;


namespace Espl.Linkup.Web.Tests.Controllers
{
    [TestClass]
    public class RoomControllerTest
    {
        [TestMethod]
        public void getAllRoom()
        {
            // Arrange
            RoomController controller = new RoomController();

            var actResult = controller.Get();
            // Act
            var result = actResult as OkNegotiatedContentResult<List<Room>>;

            // Assert
            Assert.IsNotNull(result);

            Assert.IsTrue(result.Content.Count >= 1);
        }


        [TestMethod]
        public void getRoom()
        {
            // Arrange
            RoomController controller = new RoomController();

            var actResult = controller.Get(1);
            // Act
            var result = actResult as OkNegotiatedContentResult<Room>;

            // Assert
            Assert.IsNotNull(result);
            Assert.IsTrue(result.Content.ID == 1);
        }


        [TestMethod]
        public void PostRoom()
        {
            // Arrange
            RoomController controller = new RoomController();

            Room RoomObj = new Room
            {
                User = new User { ID = 1 },
                Name = "New Room",
            };
            var actResult = controller.Post(RoomObj);
            // Act
            var result = actResult as OkNegotiatedContentResult<Room>;

            // Assert
            Assert.IsNotNull(result);
            Assert.IsTrue(result.Content.ID > 0);
        }



        [TestMethod]
        public void PutRoom()
        {
            // Arrange
            RoomController controller = new RoomController();

            Room RoomObj = new Room
            {
                User = new User { ID = 1 },
                Name = "Put request sucessfull",
                ID = 1
            };
            var actResult = controller.Put(1, RoomObj);
            // Act
            var result = actResult as OkNegotiatedContentResult<Room>;

            // Assert
            Assert.IsNotNull(result);
            Assert.IsTrue(result.Content.Name.Equals("Put request sucessfull"));
        }



        [TestMethod]
        public void DeleteRoom()
        {
            // Arrange
            RoomController controller = new RoomController();

            var actResult = controller.Delete(1);
            // Act
            var result = actResult as OkNegotiatedContentResult<bool>;

            // Assert
            Assert.IsNotNull(result);
            Assert.IsTrue(result.Content == true);
        }

    }
}
