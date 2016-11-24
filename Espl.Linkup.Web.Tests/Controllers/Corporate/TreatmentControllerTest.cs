using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

using System.Web.Mvc;
using System.Collections.Generic;
using Espl.Linkup.Web.Controllers.Leaves;
using System.Web.Http.Results;
using Espl.Linkup.Web.Controllers.Corporate;
using Espl.Linkup.Domain.Corporate.Treatments;
using Espl.Linkup.Web.Controllers.Corporate.Treatments;


namespace Espl.Linkup.Web.Tests.Controllers
{
    [TestClass]
    public class TreatmentControllerTest
    {
        [TestMethod]
        public void getAllTreatment()
        {
            // Arrange
            TreatmentController controller = new TreatmentController();

            var actResult = controller.Get();
            // Act
            var result = actResult as OkNegotiatedContentResult<List<Treatment>>;

            // Assert
            Assert.IsNotNull(result);
            Assert.IsTrue(result.Content.Count >= 2);
        }


        [TestMethod]
        public void getTreatment()
        {
            // Arrange
            TreatmentController controller = new TreatmentController();

            var actResult = controller.Get(1);
            // Act
            var result = actResult as OkNegotiatedContentResult<Treatment>;

            // Assert
            Assert.IsNotNull(result);
            Assert.IsTrue(result.Content.ID == 1);
        }


        [TestMethod]
        public void PostTreatment()
        {
            // Arrange
            TreatmentController controller = new TreatmentController();

            Treatment TreatmentObj = new Treatment
            {
                TreatmentName = "Third",
            };
            var actResult = controller.Post(TreatmentObj);
            // Act
            var result = actResult as OkNegotiatedContentResult<Treatment>;

            // Assert
            Assert.IsNotNull(result);
            Assert.IsTrue(result.Content.ID > 0);
        }



        [TestMethod]
        public void PutTreatment()
        {
            // Arrange
            TreatmentController controller = new TreatmentController();

            Treatment TreatmentObj = new Treatment
            {
                TreatmentName = "Put request sucessfull",
                ID = 2
            };
            var actResult = controller.Put(2, TreatmentObj);
            // Act
            var result = actResult as OkNegotiatedContentResult<Treatment>;

            // Assert
            Assert.IsNotNull(result);
            Assert.IsTrue(result.Content.TreatmentName.Equals("Put request sucessfull"));
        }



        [TestMethod]
        public void DeleteTreatment()
        {
            // Arrange
            TreatmentController controller = new TreatmentController();

            var actResult = controller.Delete(1);
            // Act
            var result = actResult as OkNegotiatedContentResult<bool>;

            // Assert
            Assert.IsNotNull(result);
            Assert.IsTrue(result.Content == true);
        }

    }
}
