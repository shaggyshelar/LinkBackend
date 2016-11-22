using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

using System.Web.Mvc;
using System.Collections.Generic;
using Espl.Linkup.Web.Controllers.Leaves;
using System.Web.Http.Results;

namespace Espl.Linkup.Web.Tests.Controllers
{
    [TestClass]
    public class LeaveDetailControllerTest
    {
        [TestMethod]
        public void getAllLeaveDetals()
        {
            // Arrange
            LeaveDetailController controller = new LeaveDetailController();

            var actResult = controller.Get();
            // Act
            var result = actResult as OkNegotiatedContentResult<List<Espl.Linkup.Domain.Leaves.LeaveDetail.LeaveDetail>>;

            // Assert
            Assert.IsNotNull(result);
            Assert.IsTrue(result.Content.Count > 0);
        }


        [TestMethod]
        public void getLeaveDetals()
        {
            // Arrange
            LeaveDetailController controller = new LeaveDetailController();

            var actResult = controller.Get(1);
            // Act
            var result = actResult as OkNegotiatedContentResult<Espl.Linkup.Domain.Leaves.LeaveDetail.LeaveDetail>;

            // Assert
            Assert.IsNotNull(result);
            Assert.IsTrue(result.Content.ID > 0);
        }


        [TestMethod]
        public void PostLeaveDetals()
        {
            // Arrange
            LeaveDetailController controller = new LeaveDetailController();

            Espl.Linkup.Domain.Leaves.LeaveDetail.LeaveDetail LeaveDetalsObj = new Espl.Linkup.Domain.Leaves.LeaveDetail.LeaveDetail
                 {
                     NumberOfLeave = 12,
                     HalfDayAbsent = 0,
                     HalfDayLeave = 1

                 };
           // var actResult = controller.Post(LeaveDetalsObj);
            // Act
            //var result = actResult as OkNegotiatedContentResult<Espl.Linkup.Domain.LeavesDetail.LeaveDetail>;

            //// Assert
            //Assert.IsNotNull(result);
            //Assert.IsTrue(result.Content.ID > 0);
        }



        [TestMethod]
        public void PutLeaveDetals()
        {
            // Arrange
            LeaveDetailController controller = new LeaveDetailController();

            Espl.Linkup.Domain.Leaves.LeaveDetail.LeaveDetail LeaveDetalsObj = new Espl.Linkup.Domain.Leaves.LeaveDetail.LeaveDetail
            {
                ID=1,
                NumberOfLeave = 12,
                HalfDayAbsent = 0,
                HalfDayLeave = 1

            };
            //var actResult = controller.Post(LeaveDetalsObj);
            //// Act
            //var result = actResult as OkNegotiatedContentResult<Espl.Linkup.Domain.Leaves.LeaveDetail.LeaveDetail>;

            //// Assert
            //Assert.IsNotNull(result);
            //Assert.IsTrue(result.Content.NumberOfLeave.Equals(12));
        }



        [TestMethod]
        public void DeleteLeaveDetals()
        {
            // Arrange
            LeaveDetailController controller = new LeaveDetailController();

            //var actResult = controller.Delete(1);
            //// Act
            //var result = actResult as OkNegotiatedContentResult<bool>;

            //// Assert
            //Assert.IsNotNull(result);
            //Assert.IsTrue(result.Content== true);
        }

    }
}
