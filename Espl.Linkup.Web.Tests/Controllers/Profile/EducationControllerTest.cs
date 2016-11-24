using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

using System.Web.Mvc;
using System.Collections.Generic;
using Espl.Linkup.Web.Controllers.Leaves;
using System.Web.Http.Results;
using Espl.Linkup.Web.Controllers.Profile;
using Espl.Linkup.Domain.Profile.Education;

namespace Espl.Linkup.Web.Tests.Controllers
{
    [TestClass]
    public class EducationControllerTest
    {
        [TestMethod]
        public void getAllEducation()
        {
            // Arrange
            EducationController controller = new EducationController();

            var actResult = controller.Get();
            // Act
            var result = actResult as OkNegotiatedContentResult<List<Education>>;

            // Assert
            Assert.IsNotNull(result);
            Assert.IsTrue(result.Content.Count >= 1);
        }


        [TestMethod]
        public void getEducation()
        {
            // Arrange
            EducationController controller = new EducationController();

            var actResult = controller.Get(1);
            // Act
            var result = actResult as OkNegotiatedContentResult<Education>;

            // Assert
            Assert.IsNotNull(result);
            Assert.IsTrue(result.Content.ID == 1);
        }


        [TestMethod]
        public void PostEducation()
        {
            // Arrange
            EducationController controller = new EducationController();

            Education EducationObj = new Education
                 {
                     Degree = "MCA",
                     Comments = "Good Work",
                 };
            var actResult = controller.Post(EducationObj);
            // Act
            var result = actResult as OkNegotiatedContentResult<Education>;

            // Assert
            Assert.IsNotNull(result);
            Assert.IsTrue(result.Content.ID > 0);
        }



        [TestMethod]
        public void PutEducation()
        {
            // Arrange
            EducationController controller = new EducationController();

            Education EducationObj = new Education
            {
                Degree = "Put request sucessfull",
                Comments = "Good Work",
                ID = 1
            };
            var actResult = controller.Put(1, EducationObj);
            // Act
            var result = actResult as OkNegotiatedContentResult<Education>;

            // Assert
            Assert.IsNotNull(result);
            Assert.IsTrue(result.Content.Degree.Equals("Put request sucessfull"));
        }



        [TestMethod]
        public void DeleteEducation()
        {
            // Arrange
            EducationController controller = new EducationController();

            var actResult = controller.Delete(1);
            // Act
            var result = actResult as OkNegotiatedContentResult<bool>;

            // Assert
            Assert.IsNotNull(result);
            Assert.IsTrue(result.Content == true);
        }

    }
}
