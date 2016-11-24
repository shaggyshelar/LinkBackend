using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

using System.Web.Mvc;
using System.Collections.Generic;
using Espl.Linkup.Web.Controllers.Leaves;
using System.Web.Http.Results;
using Espl.Linkup.Web.Controllers.Profile;
using Espl.Linkup.Domain.Profile.Address;

namespace Espl.Linkup.Web.Tests.Controllers
{
    [TestClass]
    public class AddressControllerTest
    {
        [TestMethod]
        public void getAllAddress()
        {
            // Arrange
            AddressController controller = new AddressController();

            var actResult = controller.Get();
            // Act
            var result = actResult as OkNegotiatedContentResult<List<Address>>;

            // Assert
            Assert.IsNotNull(result);
            Assert.IsTrue(result.Content.Count >= 1);
        }


        [TestMethod]
        public void getAddress()
        {
            // Arrange
            AddressController controller = new AddressController();

            var actResult = controller.Get(1);
            // Act
            var result = actResult as OkNegotiatedContentResult<Address>;

            // Assert
            Assert.IsNotNull(result);
            Assert.IsTrue(result.Content.ID == 1);
        }


        [TestMethod]
        public void PostAddress()
        {
            // Arrange
            AddressController controller = new AddressController();

            Address AddressObj = new Address
                 {
                     CurrentAdd="Pune",
                     Comments = "Good Work",
                 };
            var actResult = controller.Post(AddressObj);
            // Act
            var result = actResult as OkNegotiatedContentResult<Address>;

            // Assert
            Assert.IsNotNull(result);
            Assert.IsTrue(result.Content.ID > 0);
        }



        [TestMethod]
        public void PutAddress()
        {
            // Arrange
            AddressController controller = new AddressController();

            Address AddressObj = new Address
            {
                CurrentAdd = "Put request sucessfull",
                Comments = "Good Work",
                ID = 1
            };
            var actResult = controller.Put(1, AddressObj);
            // Act
            var result = actResult as OkNegotiatedContentResult<Address>;

            // Assert
            Assert.IsNotNull(result);
            Assert.IsTrue(result.Content.CurrentAdd.Equals("Put request sucessfull"));
        }



        [TestMethod]
        public void DeleteAddress()
        {
            // Arrange
            AddressController controller = new AddressController();

            var actResult = controller.Delete(1);
            // Act
            var result = actResult as OkNegotiatedContentResult<bool>;

            // Assert
            Assert.IsNotNull(result);
            Assert.IsTrue(result.Content == true);
        }

    }
}
