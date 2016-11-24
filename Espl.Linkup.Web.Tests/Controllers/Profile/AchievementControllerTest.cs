using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

using System.Web.Mvc;
using System.Collections.Generic;
using Espl.Linkup.Web.Controllers.Leaves;
using System.Web.Http.Results;
using Espl.Linkup.Web.Controllers.Profile;
using Espl.Linkup.Domain.Profile.Achievement;

namespace Espl.Linkup.Web.Tests.Controllers
{
    [TestClass]
    public class AchievementControllerTest
    {
        [TestMethod]
        public void getAllAchievement()
        {
            // Arrange
            AchievementController controller = new AchievementController();

            var actResult = controller.Get();
            // Act
            var result = actResult as OkNegotiatedContentResult<List<Achievement>>;

            // Assert
            Assert.IsNotNull(result);
            Assert.IsTrue(result.Content.Count >= 1);
        }


        [TestMethod]
        public void getAchievement()
        {
            // Arrange
            AchievementController controller = new AchievementController();

            var actResult = controller.Get(1);
            // Act
            var result = actResult as OkNegotiatedContentResult<Achievement>;

            // Assert
            Assert.IsNotNull(result);
            Assert.IsTrue(result.Content.ID == 1);
        }


        [TestMethod]
        public void PostAchievement()
        {
            // Arrange
            AchievementController controller = new AchievementController();

            Achievement AchievementObj = new Achievement
                 {
                     Name = "Award",
                     Comments = "Good Work",
                 };
            var actResult = controller.Post(AchievementObj);
            // Act
            var result = actResult as OkNegotiatedContentResult<Achievement>;

            // Assert
            Assert.IsNotNull(result);
            Assert.IsTrue(result.Content.ID > 0);
        }



        [TestMethod]
        public void PutAchievement()
        {
            // Arrange
            AchievementController controller = new AchievementController();

            Achievement AchievementObj = new Achievement
            {
                Name = "Put request sucessfull",
                Comments = "Good Work",
                ID = 1
            };
            var actResult = controller.Put(1, AchievementObj);
            // Act
            var result = actResult as OkNegotiatedContentResult<Achievement>;

            // Assert
            Assert.IsNotNull(result);
            Assert.IsTrue(result.Content.Name.Equals("Put request sucessfull"));
        }



        [TestMethod]
        public void DeleteAchievement()
        {
            // Arrange
            AchievementController controller = new AchievementController();

            var actResult = controller.Delete(1);
            // Act
            var result = actResult as OkNegotiatedContentResult<bool>;

            // Assert
            Assert.IsNotNull(result);
            Assert.IsTrue(result.Content == true);
        }

    }
}
