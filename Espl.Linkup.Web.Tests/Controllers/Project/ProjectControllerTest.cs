using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

using System.Web.Mvc;
using System.Collections.Generic;
using Espl.Linkup.Web.Controllers.Leaves;
using System.Web.Http.Results;
using Espl.Linkup.Web.Controllers.Projects;
using Espl.Linkup.Domain.Projects;
using Espl.Linkup.Domain.Projects;
using Espl.Linkup.Domain.Projects.Tasks;

namespace Espl.Linkup.Web.Tests.Controllers
{
    [TestClass]
    public class ProjectControllerTest
    {
        [TestMethod]
        public void getAllProject()
        {
            // Arrange
            ProjectController controller = new ProjectController();

            var actResult = controller.Get();
            // Act
            var result = actResult as OkNegotiatedContentResult<List<Project>>;

            // Assert
            Assert.IsNotNull(result);
            Assert.IsTrue(result.Content.Count >= 1);
        }


        [TestMethod]
        public void getProject()
        {
            // Arrange
            ProjectController controller = new ProjectController();

            var actResult = controller.Get(1);
            // Act
            var result = actResult as OkNegotiatedContentResult<Project>;

            // Assert
            Assert.IsNotNull(result);
            Assert.IsTrue(result.Content.ID == 1);
        }


        [TestMethod]
        public void PostProject()
        {
            // Arrange
            ProjectController controller = new ProjectController();

            Project ProjectObj = new Project
                 {
                     Name = "Sample"
                 };
            var actResult = controller.Post(ProjectObj);
            // Act
            var result = actResult as OkNegotiatedContentResult<Project>;

            // Assert
            Assert.IsNotNull(result);
            Assert.IsTrue(result.Content.ID > 2);
        }



        [TestMethod]
        public void PutProject()
        {
            // Arrange
            ProjectController controller = new ProjectController();

            Project ProjectObj = new Project
            {
                Name = "Put request sucessfull",
                ID = 1
            };
            var actResult = controller.Put(1, ProjectObj);
            // Act
            var result = actResult as OkNegotiatedContentResult<Project>;

            // Assert
            Assert.IsNotNull(result);
            Assert.IsTrue(result.Content.Name.Equals("Put request sucessfull"));
        }



        [TestMethod]
        public void DeleteProject()
        {
            // Arrange
            ProjectController controller = new ProjectController();

            var actResult = controller.Delete(1);
            // Act
            var result = actResult as OkNegotiatedContentResult<bool>;

            // Assert
            Assert.IsNotNull(result);
            Assert.IsTrue(result.Content == true);
        }

    }
}
