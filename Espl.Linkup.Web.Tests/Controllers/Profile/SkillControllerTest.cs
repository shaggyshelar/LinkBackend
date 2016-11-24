using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

using System.Web.Mvc;
using System.Collections.Generic;
using Espl.Linkup.Web.Controllers.Leaves;
using System.Web.Http.Results;
using Espl.Linkup.Web.Controllers.Profile;
using Espl.Linkup.Domain.Profile.Skill;

namespace Espl.Linkup.Web.Tests.Controllers
{
    [TestClass]
    public class SkillControllerTest
    {
        [TestMethod]
        public void getAllSkill()
        {
            // Arrange
            SkillController controller = new SkillController();

            var actResult = controller.Get();
            // Act
            var result = actResult as OkNegotiatedContentResult<List<Skill>>;

            // Assert
            Assert.IsNotNull(result);
            Assert.IsTrue(result.Content.Count >= 1);
        }


        [TestMethod]
        public void getSkill()
        {
            // Arrange
            SkillController controller = new SkillController();

            var actResult = controller.Get(1);
            // Act
            var result = actResult as OkNegotiatedContentResult<Skill>;

            // Assert
            Assert.IsNotNull(result);
            Assert.IsTrue(result.Content.ID == 1);
        }


        [TestMethod]
        public void PostSkill()
        {
            // Arrange
            SkillController controller = new SkillController();

            Skill SkillObj = new Skill
                 {
                     Description = "C#",
                     Comments = "Good Work",
                 };
            var actResult = controller.Post(SkillObj);
            // Act
            var result = actResult as OkNegotiatedContentResult<Skill>;

            // Assert
            Assert.IsNotNull(result);
            Assert.IsTrue(result.Content.ID > 0);
        }



        [TestMethod]
        public void PutSkill()
        {
            // Arrange
            SkillController controller = new SkillController();

            Skill SkillObj = new Skill
            {
                Description = "Put request sucessfull",
                Comments = "Good Work",
                ID = 1
            };
            var actResult = controller.Put(1, SkillObj);
            // Act
            var result = actResult as OkNegotiatedContentResult<Skill>;

            // Assert
            Assert.IsNotNull(result);
            Assert.IsTrue(result.Content.Description.Equals("Put request sucessfull"));
        }



        [TestMethod]
        public void DeleteSkill()
        {
            // Arrange
            SkillController controller = new SkillController();

            var actResult = controller.Delete(1);
            // Act
            var result = actResult as OkNegotiatedContentResult<bool>;

            // Assert
            Assert.IsNotNull(result);
            Assert.IsTrue(result.Content == true);
        }

    }
}
