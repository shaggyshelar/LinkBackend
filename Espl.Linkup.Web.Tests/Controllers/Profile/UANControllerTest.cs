using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

using System.Web.Mvc;
using System.Collections.Generic;
using Espl.Linkup.Web.Controllers.Leaves;
using System.Web.Http.Results;
using Espl.Linkup.Web.Controllers.Profile;
using Espl.Linkup.Domain.Profile.UAN;

namespace Espl.Linkup.Web.Tests.Controllers
{
    [TestClass]
    public class UANControllerTest
    {
        [TestMethod]
        public void getAllUAN()
        {
            // Arrange
            UANController controller = new UANController();

            var actResult = controller.Get();
            // Act
            var result = actResult as OkNegotiatedContentResult<List<UAN>>;

            // Assert
            Assert.IsNotNull(result);
            Assert.IsTrue(result.Content.Count >= 1);
        }


        [TestMethod]
        public void getUAN()
        {
            // Arrange
            UANController controller = new UANController();

            var actResult = controller.Get(1);
            // Act
            var result = actResult as OkNegotiatedContentResult<UAN>;

            // Assert
            Assert.IsNotNull(result);
            Assert.IsTrue(result.Content.ID == 1);
        }


        [TestMethod]
        public void PostUAN()
        {
            // Arrange
            UANController controller = new UANController();

            UAN UANObj = new UAN
                 {
                     Number = "123456",
                     Comments = "Good Work",
                 };
            var actResult = controller.Post(UANObj);
            // Act
            var result = actResult as OkNegotiatedContentResult<UAN>;

            // Assert
            Assert.IsNotNull(result);
            Assert.IsTrue(result.Content.ID > 0);
        }



        [TestMethod]
        public void PutUAN()
        {
            // Arrange
            UANController controller = new UANController();

            UAN UANObj = new UAN
            {
                Number = "Put request sucessfull",
                Comments = "Good Work",
                ID = 1
            };
            var actResult = controller.Put(1, UANObj);
            // Act
            var result = actResult as OkNegotiatedContentResult<UAN>;

            // Assert
            Assert.IsNotNull(result);
            Assert.IsTrue(result.Content.Number.Equals("Put request sucessfull"));
        }



        [TestMethod]
        public void DeleteUAN()
        {
            // Arrange
            UANController controller = new UANController();

            var actResult = controller.Delete(1);
            // Act
            var result = actResult as OkNegotiatedContentResult<bool>;

            // Assert
            Assert.IsNotNull(result);
            Assert.IsTrue(result.Content == true);
        }

    }
}
