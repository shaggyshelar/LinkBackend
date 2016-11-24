using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

using System.Web.Mvc;
using System.Collections.Generic;
using Espl.Linkup.Web.Controllers.Leaves;
using System.Web.Http.Results;
using Espl.Linkup.Web.Controllers.Profile;
using Espl.Linkup.Domain.Profile.Visa;

namespace Espl.Linkup.Web.Tests.Controllers
{
    [TestClass]
    public class VisaControllerTest
    {
        [TestMethod]
        public void getAllVisa()
        {
            // Arrange
            VisaController controller = new VisaController();

            var actResult = controller.Get();
            // Act
            var result = actResult as OkNegotiatedContentResult<List<Visa>>;

            // Assert
            Assert.IsNotNull(result);
            Assert.IsTrue(result.Content.Count >= 1);
        }


        [TestMethod]
        public void getVisa()
        {
            // Arrange
            VisaController controller = new VisaController();

            var actResult = controller.Get(1);
            // Act
            var result = actResult as OkNegotiatedContentResult<Visa>;

            // Assert
            Assert.IsNotNull(result);
            Assert.IsTrue(result.Content.ID == 1);
        }


        [TestMethod]
        public void PostVisa()
        {
            // Arrange
            VisaController controller = new VisaController();

            Visa VisaObj = new Visa
                 {
                     Number = "123456",
                     Comments = "Good Work",
                 };
            var actResult = controller.Post(VisaObj);
            // Act
            var result = actResult as OkNegotiatedContentResult<Visa>;

            // Assert
            Assert.IsNotNull(result);
            Assert.IsTrue(result.Content.ID > 0);
        }



        [TestMethod]
        public void PutVisa()
        {
            // Arrange
            VisaController controller = new VisaController();

            Visa VisaObj = new Visa
            {
                Number = "Put request sucessfull",
                Comments = "Good Work",
                ID = 1
            };
            var actResult = controller.Put(1, VisaObj);
            // Act
            var result = actResult as OkNegotiatedContentResult<Visa>;

            // Assert
            Assert.IsNotNull(result);
            Assert.IsTrue(result.Content.Number.Equals("Put request sucessfull"));
        }



        [TestMethod]
        public void DeleteVisa()
        {
            // Arrange
            VisaController controller = new VisaController();

            var actResult = controller.Delete(1);
            // Act
            var result = actResult as OkNegotiatedContentResult<bool>;

            // Assert
            Assert.IsNotNull(result);
            Assert.IsTrue(result.Content == true);
        }

    }
}
