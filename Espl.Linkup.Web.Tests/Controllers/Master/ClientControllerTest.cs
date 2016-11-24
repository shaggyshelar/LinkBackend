using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

using System.Web.Mvc;
using System.Collections.Generic;
using Espl.Linkup.Web.Controllers.Leaves;
using System.Web.Http.Results;
using Espl.Linkup.Web.Controllers.Master;
using Espl.Linkup.Domain.Clients;

namespace Espl.Linkup.Web.Tests.Controllers
{
    [TestClass]
    public class ClientControllerTest
    {
        [TestMethod]
        public void getAllClient()
        {
            // Arrange
            ClientController controller = new ClientController();

            var actResult = controller.Get();
            // Act
            var result = actResult as OkNegotiatedContentResult<List<Client>>;

            // Assert
            Assert.IsNotNull(result);
            Assert.IsTrue(result.Content.Count >= 2);
        }


        [TestMethod]
        public void getClient()
        {
            // Arrange
            ClientController controller = new ClientController();

            var actResult = controller.Get(1);
            // Act
            var result = actResult as OkNegotiatedContentResult<Client>;

            // Assert
            Assert.IsNotNull(result);
            Assert.IsTrue(result.Content.ID == 1);
        }


        [TestMethod]
        public void PostClient()
        {
            // Arrange
            ClientController controller = new ClientController();

            Client ClientObj = new Client
                 {
                     Name = "Test Client"

                 };
            var actResult = controller.Post(ClientObj);
            // Act
            var result = actResult as OkNegotiatedContentResult<Client>;

            // Assert
            Assert.IsNotNull(result);
            Assert.IsTrue(result.Content.ID > 0);
        }



        [TestMethod]
        public void PutClient()
        {
            // Arrange
            ClientController controller = new ClientController();

            Client ClientObj = new Client
            {
                ID = 1,
                Name = "Put request sucessfull",


            };
            var actResult = controller.Put(1, ClientObj);
            // Act
            var result = actResult as OkNegotiatedContentResult<Client>;

            // Assert
            Assert.IsNotNull(result);
            Assert.IsTrue(result.Content.Name.Equals("Put request sucessfull"));
        }



        [TestMethod]
        public void DeleteClient()
        {
            // Arrange
            ClientController controller = new ClientController();

            var actResult = controller.Delete(1);
            // Act
            var result = actResult as OkNegotiatedContentResult<bool>;

            // Assert
            Assert.IsNotNull(result);
            Assert.IsTrue(result.Content == true);
        }

    }
}
