using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

using System.Web.Mvc;
using System.Collections.Generic;
using Espl.Linkup.Web.Controllers.Leaves;
using System.Web.Http.Results;
using Espl.Linkup.Web.Controllers.Corporate;
using Espl.Linkup.Domain.Corporate.Conferences;


namespace Espl.Linkup.Web.Tests.Controllers
{
    [TestClass]
    public class ConferenceControllerTest
    {
        [TestMethod]
        public void getAllConference()
        {
            // Arrange
            ConferenceController controller = new ConferenceController();

            var actResult = controller.Get();
            // Act
            var result = actResult as OkNegotiatedContentResult<List<Conference>>;

            // Assert
            Assert.IsNotNull(result);
            Assert.IsTrue(result.Content.Count >= 2);
        }


        [TestMethod]
        public void getConference()
        {
            // Arrange
            ConferenceController controller = new ConferenceController();

            var actResult = controller.Get(1);
            // Act
            var result = actResult as OkNegotiatedContentResult<Conference>;

            // Assert
            Assert.IsNotNull(result);
            Assert.IsTrue(result.Content.ID == 1);
        }


        [TestMethod]
        public void PostConference()
        {
            // Arrange
            ConferenceController controller = new ConferenceController();

            Conference ConferenceObj = new Conference
            {
                Title = "Project Meeting",
                IsDeleted = false,
                Description = "This is Project Status Metting",
                EndTime = new DateTime(2016, 11, 11, 15, 00, 00),
                StartTime = new DateTime(2016, 11, 11,14, 00, 00),
                SpecialComments = "This is Special Comments",
            };
            var actResult = controller.Post(ConferenceObj);
            // Act
            var result = actResult as OkNegotiatedContentResult<Conference>;

            // Assert
            Assert.IsNotNull(result);
            Assert.IsTrue(result.Content.ID > 0);
        }



        [TestMethod]
        public void PutConference()
        {
            // Arrange
            ConferenceController controller = new ConferenceController();

            Conference ConferenceObj = new Conference
            {
                Title = "Put request sucessfull",
                IsDeleted = false,
                Description = "This is Project Status Metting",
                EndTime = new DateTime(2016, 11, 11, 15, 00, 00),
                StartTime = new DateTime(2016, 11, 11, 14, 00, 00),
                SpecialComments = "This is Special Comments",
                ID = 2
            };
            var actResult = controller.Put(2, ConferenceObj);
            // Act
            var result = actResult as OkNegotiatedContentResult<Conference>;

            // Assert
            Assert.IsNotNull(result);
            Assert.IsTrue(result.Content.Title.Equals("Put request sucessfull"));
        }



        [TestMethod]
        public void DeleteConference()
        {
            // Arrange
            ConferenceController controller = new ConferenceController();

            var actResult = controller.Delete(1);
            // Act
            var result = actResult as OkNegotiatedContentResult<bool>;

            // Assert
            Assert.IsNotNull(result);
            Assert.IsTrue(result.Content == true);
        }

    }
}
