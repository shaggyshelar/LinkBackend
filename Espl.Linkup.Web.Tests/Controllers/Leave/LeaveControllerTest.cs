using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

using System.Web.Mvc;
using System.Collections.Generic;
using Espl.Linkup.Web.Controllers.Leaves;
using System.Web.Http.Results;

namespace Espl.Linkup.Web.Tests.Controllers
{
    [TestClass]
    public class LeaveControllerTest
    {
        [TestMethod]
        public void getAllLeave()
        {
            // Arrange
            LeaveController controller = new LeaveController();

            var actResult = controller.Get();
            // Act
            var result = actResult as OkNegotiatedContentResult<List<Espl.Linkup.Domain.Leaves.Leave>>;

            // Assert
            Assert.IsNotNull(result);
            Assert.IsTrue(result.Content.Count > 0);
        }


        [TestMethod]
        public void getLeave()
        {
            // Arrange
            LeaveController controller = new LeaveController();

            var actResult = controller.Get(1);
            // Act
            var result = actResult as OkNegotiatedContentResult<Espl.Linkup.Domain.Leaves.Leave>;

            // Assert
            Assert.IsNotNull(result);
            Assert.IsTrue(result.Content.ID > 0);
        }


        [TestMethod]
        public void PostLeave()
        {
            // Arrange
            LeaveController controller = new LeaveController();

            Espl.Linkup.Domain.Leaves.Leave leaveObj = new Espl.Linkup.Domain.Leaves.Leave
                 {
                     NumberOfLeave = 12,
                     Reason = "Sample",
                     Status = "Approved",
                     StartDate = new DateTime(2016, 12, 12),
                     EndDate = new DateTime(2016, 12, 18)

                 };
            var actResult = controller.Post(leaveObj);
            // Act
            var result = actResult as OkNegotiatedContentResult<Espl.Linkup.Domain.Leaves.Leave>;

            // Assert
            Assert.IsNotNull(result);
            Assert.IsTrue(result.Content.ID > 0);
        }



        [TestMethod]
        public void PutLeave()
        {
            // Arrange
            LeaveController controller = new LeaveController();

            Espl.Linkup.Domain.Leaves.Leave leaveObj = new Espl.Linkup.Domain.Leaves.Leave
            {
                ID = 1,
                NumberOfLeave = 12,
                Reason = "Put request sucessfull",
                Status = "Approved",
                StartDate = new DateTime(2016, 12, 12),
                EndDate = new DateTime(2016, 12, 18)

            };
            var actResult = controller.Put(1, leaveObj);
            // Act
            var result = actResult as OkNegotiatedContentResult<Espl.Linkup.Domain.Leaves.Leave>;

            // Assert
            Assert.IsNotNull(result);
            Assert.IsTrue(result.Content.Reason.Equals("Put request sucessfull"));
        }



        [TestMethod]
        public void DeleteLeave()
        {
            // Arrange
            LeaveController controller = new LeaveController();

            var actResult = controller.Delete(1);
            // Act
            var result = actResult as OkNegotiatedContentResult<bool>;

            // Assert
            Assert.IsNotNull(result);
            Assert.IsTrue(result.Content == true);
        }

    }
}
