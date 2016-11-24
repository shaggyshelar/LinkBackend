using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

using System.Web.Mvc;
using System.Collections.Generic;
using Espl.Linkup.Web.Controllers.Leaves;
using System.Web.Http.Results;
using Espl.Linkup.Web.Controllers.Profile;
using Espl.Linkup.Domain.Profile.IDProof;

namespace Espl.Linkup.Web.Tests.Controllers
{
    [TestClass]
    public class IDProofControllerTest
    {
        [TestMethod]
        public void getAllIDProof()
        {
            // Arrange
            IDProofController controller = new IDProofController();

            var actResult = controller.Get();
            // Act
            var result = actResult as OkNegotiatedContentResult<List<IDProof>>;

            // Assert
            Assert.IsNotNull(result);
            Assert.IsTrue(result.Content.Count >= 1);
        }


        [TestMethod]
        public void getIDProof()
        {
            // Arrange
            IDProofController controller = new IDProofController();

            var actResult = controller.Get(1);
            // Act
            var result = actResult as OkNegotiatedContentResult<IDProof>;

            // Assert
            Assert.IsNotNull(result);
            Assert.IsTrue(result.Content.ID == 1);
        }


        [TestMethod]
        public void PostIDProof()
        {
            // Arrange
            IDProofController controller = new IDProofController();

            IDProof IDProofObj = new IDProof
                 {
                     Value = "123456",
                     Comments = "Good Work",
                 };
            var actResult = controller.Post(IDProofObj);
            // Act
            var result = actResult as OkNegotiatedContentResult<IDProof>;

            // Assert
            Assert.IsNotNull(result);
            Assert.IsTrue(result.Content.ID > 0);
        }



        [TestMethod]
        public void PutIDProof()
        {
            // Arrange
            IDProofController controller = new IDProofController();

            IDProof IDProofObj = new IDProof
            {
                Value = "Put request sucessfull",
                Comments = "Good Work",
                ID = 1
            };
            var actResult = controller.Put(1, IDProofObj);
            // Act
            var result = actResult as OkNegotiatedContentResult<IDProof>;

            // Assert
            Assert.IsNotNull(result);
            Assert.IsTrue(result.Content.Value.Equals("Put request sucessfull"));
        }



        [TestMethod]
        public void DeleteIDProof()
        {
            // Arrange
            IDProofController controller = new IDProofController();

            var actResult = controller.Delete(1);
            // Act
            var result = actResult as OkNegotiatedContentResult<bool>;

            // Assert
            Assert.IsNotNull(result);
            Assert.IsTrue(result.Content == true);
        }

    }
}
