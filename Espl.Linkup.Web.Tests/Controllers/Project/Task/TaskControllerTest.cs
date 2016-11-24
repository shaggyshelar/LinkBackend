using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

using System.Web.Mvc;
using System.Collections.Generic;
using Espl.Linkup.Web.Controllers.Leaves;
using System.Web.Http.Results;
using Espl.Linkup.Web.Controllers.Projects.Tasks;
using Espl.Linkup.Domain.Projects.Tasks;

namespace Espl.Linkup.Web.Tests.Controllers
{
    [TestClass]
    public class TaskControllerTest
    {
        [TestMethod]
        public void getAllTask()
        {
            // Arrange
            TaskController controller = new TaskController();

            var actResult = controller.Get();
            // Act
            var result = actResult as OkNegotiatedContentResult<List<Task>>;

            // Assert
            Assert.IsNotNull(result);
            Assert.IsTrue(result.Content.Count >= 1);
        }


        [TestMethod]
        public void getTask()
        {
            // Arrange
            TaskController controller = new TaskController();

            var actResult = controller.Get(1);
            // Act
            var result = actResult as OkNegotiatedContentResult<Task>;

            // Assert
            Assert.IsNotNull(result);
            Assert.IsTrue(result.Content.ID == 1);
        }


        [TestMethod]
        public void PostTask()
        {
            // Arrange
            TaskController controller = new TaskController();

            Task TaskObj = new Task
                 {
                     Name = "Sample"
                 };
            var actResult = controller.Post(TaskObj);
            // Act
            var result = actResult as OkNegotiatedContentResult<Task>;

            // Assert
            Assert.IsNotNull(result);
            Assert.IsTrue(result.Content.ID > 2);
        }



        [TestMethod]
        public void PutTask()
        {
            // Arrange
            TaskController controller = new TaskController();

            Task TaskObj = new Task
            {
                Name = "Put request sucessfull",
                ID = 1
            };
            var actResult = controller.Put(1, TaskObj);
            // Act
            var result = actResult as OkNegotiatedContentResult<Task>;

            // Assert
            Assert.IsNotNull(result);
            Assert.IsTrue(result.Content.Name.Equals("Put request sucessfull"));
        }



        [TestMethod]
        public void DeleteTask()
        {
            // Arrange
            TaskController controller = new TaskController();

            var actResult = controller.Delete(1);
            // Act
            var result = actResult as OkNegotiatedContentResult<bool>;

            // Assert
            Assert.IsNotNull(result);
            Assert.IsTrue(result.Content == true);
        }

    }
}
