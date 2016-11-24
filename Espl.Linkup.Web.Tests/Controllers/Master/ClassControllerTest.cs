using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

using System.Web.Mvc;
using System.Collections.Generic;
using Espl.Linkup.Web.Controllers.Leaves;
using System.Web.Http.Results;
using Espl.Linkup.Web.Controllers.Master;
using Espl.Linkup.Domain.Classes;

namespace Espl.Linkup.Web.Tests.Controllers
{
    [TestClass]
    public class ClassControllerTest
    {
        [TestMethod]
        public void getAllClass()
        {
            // Arrange
            ClassController controller = new ClassController();

            var actResult = controller.Get();
            // Act
            var result = actResult as OkNegotiatedContentResult<List<Class>>;

            // Assert
            Assert.IsNotNull(result);
            Assert.IsTrue(result.Content.Count >= 2);
        }


        [TestMethod]
        public void getClass()
        {
            // Arrange
            ClassController controller = new ClassController();

            var actResult = controller.Get(1);
            // Act
            var result = actResult as OkNegotiatedContentResult<Class>;

            // Assert
            Assert.IsNotNull(result);
            Assert.IsTrue(result.Content.ID == 1);
        }


        [TestMethod]
        public void PostClass()
        {
            // Arrange
            ClassController controller = new ClassController();

            Class ClassObj = new Class
                 {
                     Name = "Graduation"

                 };
            var actResult = controller.Post(ClassObj);
            // Act
            var result = actResult as OkNegotiatedContentResult<Class>;

            // Assert
            Assert.IsNotNull(result);
            Assert.IsTrue(result.Content.ID > 0);
        }



        [TestMethod]
        public void PutClass()
        {
            // Arrange
            ClassController controller = new ClassController();

            Class ClassObj = new Class
            {
                ID = 1,
                Name = "Put request sucessfull",


            };
            var actResult = controller.Put(1, ClassObj);
            // Act
            var result = actResult as OkNegotiatedContentResult<Class>;

            // Assert
            Assert.IsNotNull(result);
            Assert.IsTrue(result.Content.Name.Equals("Put request sucessfull"));
        }



        [TestMethod]
        public void DeleteClass()
        {
            // Arrange
            ClassController controller = new ClassController();

            var actResult = controller.Delete(1);
            // Act
            var result = actResult as OkNegotiatedContentResult<bool>;

            // Assert
            Assert.IsNotNull(result);
            Assert.IsTrue(result.Content == true);
        }

    }
}
