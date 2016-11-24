using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

using System.Web.Mvc;
using System.Collections.Generic;
using Espl.Linkup.Web.Controllers.Leaves;
using System.Web.Http.Results;
using Espl.Linkup.Web.Controllers.Master;
using Espl.Linkup.Domain.IDProofTypes;

namespace Espl.Linkup.Web.Tests.Controllers
{
    [TestClass]
    public class IDProofTypeControllerTest
    {
        [TestMethod]
        public void getAllIDProofType()
        {
            // Arrange
            IDProofTypeController controller = new IDProofTypeController();

            var actResult = controller.Get();
            // Act
            var result = actResult as OkNegotiatedContentResult<List<IDProofType>>;

            // Assert
            Assert.IsNotNull(result);
            Assert.IsTrue(result.Content.Count >= 2);
        }


        [TestMethod]
        public void getIDProofType()
        {
            // Arrange
            IDProofTypeController controller = new IDProofTypeController();

            var actResult = controller.Get(1);
            // Act
            var result = actResult as OkNegotiatedContentResult<IDProofType>;

            // Assert
            Assert.IsNotNull(result);
            Assert.IsTrue(result.Content.ID == 1);
        }


        [TestMethod]
        public void PostIDProofType()
        {
            // Arrange
            IDProofTypeController controller = new IDProofTypeController();

            IDProofType IDProofTypeObj = new IDProofType
                 {
                     Name = "PAN"

                 };
            var actResult = controller.Post(IDProofTypeObj);
            // Act
            var result = actResult as OkNegotiatedContentResult<IDProofType>;

            // Assert
            Assert.IsNotNull(result);
            Assert.IsTrue(result.Content.ID > 0);
        }



        [TestMethod]
        public void PutIDProofType()
        {
            // Arrange
            IDProofTypeController controller = new IDProofTypeController();

            IDProofType IDProofTypeObj = new IDProofType
            {
                ID = 1,
                Name = "Put request sucessfull",


            };
            var actResult = controller.Put(1, IDProofTypeObj);
            // Act
            var result = actResult as OkNegotiatedContentResult<IDProofType>;

            // Assert
            Assert.IsNotNull(result);
            Assert.IsTrue(result.Content.Name.Equals("Put request sucessfull"));
        }



        [TestMethod]
        public void DeleteIDProofType()
        {
            // Arrange
            IDProofTypeController controller = new IDProofTypeController();

            var actResult = controller.Delete(1);
            // Act
            var result = actResult as OkNegotiatedContentResult<bool>;

            // Assert
            Assert.IsNotNull(result);
            Assert.IsTrue(result.Content == true);
        }

    }
}
