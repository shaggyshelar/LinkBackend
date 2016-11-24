using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

using System.Web.Mvc;
using System.Collections.Generic;
using Espl.Linkup.Web.Controllers.Leaves;
using System.Web.Http.Results;
using Espl.Linkup.Web.Controllers.Corporate;
using Espl.Linkup.Domain.Roles;
using Espl.Linkup.Domain.Profile.Users;
using Espl.Linkup.Domain.Departments;

namespace Espl.Linkup.Web.Tests.Controllers
{
    [TestClass]
    public class RoleControllerTest
    {
        [TestMethod]
        public void getAllRole()
        {
            // Arrange
            RoleController controller = new RoleController();

            var actResult = controller.Get();
            // Act
            var result = actResult as OkNegotiatedContentResult<List<Role>>;

            // Assert
            Assert.IsNotNull(result);

            Assert.IsTrue(result.Content.Count >= 1);
        }


        [TestMethod]
        public void getRole()
        {
            // Arrange
            RoleController controller = new RoleController();

            var actResult = controller.Get(1);
            // Act
            var result = actResult as OkNegotiatedContentResult<Role>;

            // Assert
            Assert.IsNotNull(result);
            Assert.IsTrue(result.Content.ID == 1);
        }


        [TestMethod]
        public void PostRole()
        {
            // Arrange
            RoleController controller = new RoleController();

            Role RoleObj = new Role
            {
                User = new User { ID = 1 },
                Name = "New Role",
            };
            var actResult = controller.Post(RoleObj);
            // Act
            var result = actResult as OkNegotiatedContentResult<Role>;

            // Assert
            Assert.IsNotNull(result);
            Assert.IsTrue(result.Content.ID > 0);
        }



        [TestMethod]
        public void PutRole()
        {
            // Arrange
            RoleController controller = new RoleController();

            Role RoleObj = new Role
            {
                User = new User { ID = 1 },
                Name = "Put request sucessfull",
                ID = 1
            };
            var actResult = controller.Put(1, RoleObj);
            // Act
            var result = actResult as OkNegotiatedContentResult<Role>;

            // Assert
            Assert.IsNotNull(result);
            Assert.IsTrue(result.Content.Name.Equals("Put request sucessfull"));
        }



        [TestMethod]
        public void DeleteRole()
        {
            // Arrange
            RoleController controller = new RoleController();

            var actResult = controller.Delete(1);
            // Act
            var result = actResult as OkNegotiatedContentResult<bool>;

            // Assert
            Assert.IsNotNull(result);
            Assert.IsTrue(result.Content == true);
        }

    }
}
