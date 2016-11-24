using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

using System.Web.Mvc;
using System.Collections.Generic;
using Espl.Linkup.Web.Controllers.Leaves;
using System.Web.Http.Results;
using Espl.Linkup.Web.Controllers.Profile;
using Espl.Linkup.Domain.Profile.EmploymentHistory;

namespace Espl.Linkup.Web.Tests.Controllers
{
    [TestClass]
    public class EmploymentHistoryControllerTest
    {
        [TestMethod]
        public void getAllEmploymentHistory()
        {
            // Arrange
            EmploymentHistoryController controller = new EmploymentHistoryController();

            var actResult = controller.Get();
            // Act
            var result = actResult as OkNegotiatedContentResult<List<EmploymentHistory>>;

            // Assert
            Assert.IsNotNull(result);
            Assert.IsTrue(result.Content.Count >= 1);
        }


        [TestMethod]
        public void getEmploymentHistory()
        {
            // Arrange
            EmploymentHistoryController controller = new EmploymentHistoryController();

            var actResult = controller.Get(1);
            // Act
            var result = actResult as OkNegotiatedContentResult<EmploymentHistory>;

            // Assert
            Assert.IsNotNull(result);
            Assert.IsTrue(result.Content.ID == 1);
        }


        [TestMethod]
        public void PostEmploymentHistory()
        {
            // Arrange
            EmploymentHistoryController controller = new EmploymentHistoryController();

            EmploymentHistory EmploymentHistoryObj = new EmploymentHistory
                 {
                     Designation = "Dev",
                     Comments = "Good Work",
                 };
            var actResult = controller.Post(EmploymentHistoryObj);
            // Act
            var result = actResult as OkNegotiatedContentResult<EmploymentHistory>;

            // Assert
            Assert.IsNotNull(result);
            Assert.IsTrue(result.Content.ID > 0);
        }



        [TestMethod]
        public void PutEmploymentHistory()
        {
            // Arrange
            EmploymentHistoryController controller = new EmploymentHistoryController();

            EmploymentHistory EmploymentHistoryObj = new EmploymentHistory
            {
                Designation = "Put request sucessfull",
                Comments = "Good Work",
                ID = 1
            };
            var actResult = controller.Put(1, EmploymentHistoryObj);
            // Act
            var result = actResult as OkNegotiatedContentResult<EmploymentHistory>;

            // Assert
            Assert.IsNotNull(result);
            Assert.IsTrue(result.Content.Designation.Equals("Put request sucessfull"));
        }



        [TestMethod]
        public void DeleteEmploymentHistory()
        {
            // Arrange
            EmploymentHistoryController controller = new EmploymentHistoryController();

            var actResult = controller.Delete(1);
            // Act
            var result = actResult as OkNegotiatedContentResult<bool>;

            // Assert
            Assert.IsNotNull(result);
            Assert.IsTrue(result.Content == true);
        }

    }
}
