using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

using System.Web.Mvc;
using System.Collections.Generic;
using Espl.Linkup.Web.Controllers.Leaves;
using System.Web.Http.Results;
using Espl.Linkup.Web.Controllers.Profile;
using Espl.Linkup.Domain.Profile.Certification;

namespace Espl.Linkup.Web.Tests.Controllers
{
    [TestClass]
    public class CertificationControllerTest
    {
        [TestMethod]
        public void getAllCertification()
        {
            // Arrange
            CertificationController controller = new CertificationController();

            var actResult = controller.Get();
            // Act
            var result = actResult as OkNegotiatedContentResult<List<Certification>>;

            // Assert
            Assert.IsNotNull(result);
            Assert.IsTrue(result.Content.Count >= 1);
        }


        [TestMethod]
        public void getCertification()
        {
            // Arrange
            CertificationController controller = new CertificationController();

            var actResult = controller.Get(1);
            // Act
            var result = actResult as OkNegotiatedContentResult<Certification>;

            // Assert
            Assert.IsNotNull(result);
            Assert.IsTrue(result.Content.ID == 1);
        }


        [TestMethod]
        public void PostCertification()
        {
            // Arrange
            CertificationController controller = new CertificationController();

            Certification CertificationObj = new Certification
                 {
                     Name = ".Net",
                     Comments = "Good Work",
                 };
            var actResult = controller.Post(CertificationObj);
            // Act
            var result = actResult as OkNegotiatedContentResult<Certification>;

            // Assert
            Assert.IsNotNull(result);
            Assert.IsTrue(result.Content.ID > 0);
        }



        [TestMethod]
        public void PutCertification()
        {
            // Arrange
            CertificationController controller = new CertificationController();

            Certification CertificationObj = new Certification
            {
                Name = "Put request sucessfull",
                Comments = "Good Work",
                ID = 1
            };
            var actResult = controller.Put(1, CertificationObj);
            // Act
            var result = actResult as OkNegotiatedContentResult<Certification>;

            // Assert
            Assert.IsNotNull(result);
            Assert.IsTrue(result.Content.Name.Equals("Put request sucessfull"));
        }



        [TestMethod]
        public void DeleteCertification()
        {
            // Arrange
            CertificationController controller = new CertificationController();

            var actResult = controller.Delete(1);
            // Act
            var result = actResult as OkNegotiatedContentResult<bool>;

            // Assert
            Assert.IsNotNull(result);
            Assert.IsTrue(result.Content == true);
        }

    }
}
