using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

using System.Web.Mvc;
using System.Collections.Generic;
using Espl.Linkup.Web.Controllers.Leaves;
using System.Web.Http.Results;
using Espl.Linkup.Web.Controllers.Profile;
using Espl.Linkup.Domain.Profile.Experience;

namespace Espl.Linkup.Web.Tests.Controllers
{
    [TestClass]
    public class ExperienceControllerTest
    {
        [TestMethod]
        public void getAllExperience()
        {
            // Arrange
            ExperienceController controller = new ExperienceController();

            var actResult = controller.Get();
            // Act
            var result = actResult as OkNegotiatedContentResult<List<Experience>>;

            // Assert
            Assert.IsNotNull(result);
            Assert.IsTrue(result.Content.Count >= 1);
        }


        [TestMethod]
        public void getExperience()
        {
            // Arrange
            ExperienceController controller = new ExperienceController();

            var actResult = controller.Get(1);
            // Act
            var result = actResult as OkNegotiatedContentResult<Experience>;

            // Assert
            Assert.IsNotNull(result);
            Assert.IsTrue(result.Content.ID == 1);
        }


        [TestMethod]
        public void PostExperience()
        {
            // Arrange
            ExperienceController controller = new ExperienceController();

            Experience ExperienceObj = new Experience
                 {
                     Description = "Portal",
                     Comments = "Good Work",
                 };
            var actResult = controller.Post(ExperienceObj);
            // Act
            var result = actResult as OkNegotiatedContentResult<Experience>;

            // Assert
            Assert.IsNotNull(result);
            Assert.IsTrue(result.Content.ID > 0);
        }



        [TestMethod]
        public void PutExperience()
        {
            // Arrange
            ExperienceController controller = new ExperienceController();

            Experience ExperienceObj = new Experience
            {
                Description = "Put request sucessfull",
                Comments = "Good Work",
                ID = 1
            };
            var actResult = controller.Put(1, ExperienceObj);
            // Act
            var result = actResult as OkNegotiatedContentResult<Experience>;

            // Assert
            Assert.IsNotNull(result);
            Assert.IsTrue(result.Content.Description.Equals("Put request sucessfull"));
        }



        [TestMethod]
        public void DeleteExperience()
        {
            // Arrange
            ExperienceController controller = new ExperienceController();

            var actResult = controller.Delete(1);
            // Act
            var result = actResult as OkNegotiatedContentResult<bool>;

            // Assert
            Assert.IsNotNull(result);
            Assert.IsTrue(result.Content == true);
        }

    }
}
