using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

using System.Web.Mvc;
using System.Collections.Generic;
using Espl.Linkup.Web.Controllers.Leaves;
using System.Web.Http.Results;
using Espl.Linkup.Web.Controllers.Master;
using Espl.Linkup.Domain.SkillTypes;

namespace Espl.Linkup.Web.Tests.Controllers
{
    [TestClass]
    public class SkillTypeControllerTest
    {
        [TestMethod]
        public void getAllSkillType()
        {
            // Arrange
            SkillTypeController controller = new SkillTypeController();

            var actResult = controller.Get();
            // Act
            var result = actResult as OkNegotiatedContentResult<List<SkillType>>;

            // Assert
            Assert.IsNotNull(result);
            Assert.IsTrue(result.Content.Count >= 2);
        }


        [TestMethod]
        public void getSkillType()
        {
            // Arrange
            SkillTypeController controller = new SkillTypeController();

            var actResult = controller.Get(1);
            // Act
            var result = actResult as OkNegotiatedContentResult<SkillType>;

            // Assert
            Assert.IsNotNull(result);
            Assert.IsTrue(result.Content.ID == 1);
        }


        [TestMethod]
        public void PostSkillType()
        {
            // Arrange
            SkillTypeController controller = new SkillTypeController();

            SkillType SkillTypeObj = new SkillType
                 {
                     Name = "EBS"

                 };
            var actResult = controller.Post(SkillTypeObj);
            // Act
            var result = actResult as OkNegotiatedContentResult<SkillType>;

            // Assert
            Assert.IsNotNull(result);
            Assert.IsTrue(result.Content.ID > 0);
        }



        [TestMethod]
        public void PutSkillType()
        {
            // Arrange
            SkillTypeController controller = new SkillTypeController();

            SkillType SkillTypeObj = new SkillType
            {
                ID = 1,
                Name = "Put request sucessfull",


            };
            var actResult = controller.Put(1, SkillTypeObj);
            // Act
            var result = actResult as OkNegotiatedContentResult<SkillType>;

            // Assert
            Assert.IsNotNull(result);
            Assert.IsTrue(result.Content.Name.Equals("Put request sucessfull"));
        }



        [TestMethod]
        public void DeleteSkillType()
        {
            // Arrange
            SkillTypeController controller = new SkillTypeController();

            var actResult = controller.Delete(1);
            // Act
            var result = actResult as OkNegotiatedContentResult<bool>;

            // Assert
            Assert.IsNotNull(result);
            Assert.IsTrue(result.Content == true);
        }

    }
}
