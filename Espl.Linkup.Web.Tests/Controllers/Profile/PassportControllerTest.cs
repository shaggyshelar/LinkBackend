using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

using System.Web.Mvc;
using System.Collections.Generic;
using Espl.Linkup.Web.Controllers.Leaves;
using System.Web.Http.Results;
using Espl.Linkup.Web.Controllers.Profile;
using Espl.Linkup.Domain.Profile.Passport;

namespace Espl.Linkup.Web.Tests.Controllers
{
    [TestClass]
    public class PassportControllerTest
    {
        [TestMethod]
        public void getAllPassport()
        {
            // Arrange
            PassportController controller = new PassportController();

            var actResult = controller.Get();
            // Act
            var result = actResult as OkNegotiatedContentResult<List<Passport>>;

            // Assert
            Assert.IsNotNull(result);
            Assert.IsTrue(result.Content.Count >= 1);
        }


        [TestMethod]
        public void getPassport()
        {
            // Arrange
            PassportController controller = new PassportController();

            var actResult = controller.Get(1);
            // Act
            var result = actResult as OkNegotiatedContentResult<Passport>;

            // Assert
            Assert.IsNotNull(result);
            Assert.IsTrue(result.Content.ID == 1);
        }


        [TestMethod]
        public void PostPassport()
        {
            // Arrange
            PassportController controller = new PassportController();

            Passport PassportObj = new Passport
                 {
                     Number = "123456",
                     Comments = "Good Work",
                 };
            var actResult = controller.Post(PassportObj);
            // Act
            var result = actResult as OkNegotiatedContentResult<Passport>;

            // Assert
            Assert.IsNotNull(result);
            Assert.IsTrue(result.Content.ID > 0);
        }



        [TestMethod]
        public void PutPassport()
        {
            // Arrange
            PassportController controller = new PassportController();

            Passport PassportObj = new Passport
            {
                Number = "Put request sucessfull",
                Comments = "Good Work",
                ID = 1
            };
            var actResult = controller.Put(1, PassportObj);
            // Act
            var result = actResult as OkNegotiatedContentResult<Passport>;

            // Assert
            Assert.IsNotNull(result);
            Assert.IsTrue(result.Content.Number.Equals("Put request sucessfull"));
        }



        [TestMethod]
        public void DeletePassport()
        {
            // Arrange
            PassportController controller = new PassportController();

            var actResult = controller.Delete(1);
            // Act
            var result = actResult as OkNegotiatedContentResult<bool>;

            // Assert
            Assert.IsNotNull(result);
            Assert.IsTrue(result.Content == true);
        }

    }
}
