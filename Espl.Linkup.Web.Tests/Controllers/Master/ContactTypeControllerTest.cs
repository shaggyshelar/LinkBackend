using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

using System.Web.Mvc;
using System.Collections.Generic;
using Espl.Linkup.Web.Controllers.Leaves;
using System.Web.Http.Results;
using Espl.Linkup.Web.Controllers.Master;
using Espl.Linkup.Domain.ContactTypes;

namespace Espl.Linkup.Web.Tests.Controllers
{
    [TestClass]
    public class ContactTypeControllerTest
    {
        [TestMethod]
        public void getAllContactType()
        {
            // Arrange
            ContactTypeController controller = new ContactTypeController();

            var actResult = controller.Get();
            // Act
            var result = actResult as OkNegotiatedContentResult<List<ContactType>>;

            // Assert
            Assert.IsNotNull(result);
            Assert.IsTrue(result.Content.Count >= 2);
        }


        [TestMethod]
        public void getContactType()
        {
            // Arrange
            ContactTypeController controller = new ContactTypeController();

            var actResult = controller.Get(1);
            // Act
            var result = actResult as OkNegotiatedContentResult<ContactType>;

            // Assert
            Assert.IsNotNull(result);
            Assert.IsTrue(result.Content.ID == 1);
        }


        [TestMethod]
        public void PostContactType()
        {
            // Arrange
            ContactTypeController controller = new ContactTypeController();

            ContactType ContactTypeObj = new ContactType
                 {
                     Name = "Primary"

                 };
            var actResult = controller.Post(ContactTypeObj);
            // Act
            var result = actResult as OkNegotiatedContentResult<ContactType>;

            // Assert
            Assert.IsNotNull(result);
            Assert.IsTrue(result.Content.ID > 0);
        }



        [TestMethod]
        public void PutContactType()
        {
            // Arrange
            ContactTypeController controller = new ContactTypeController();

            ContactType ContactTypeObj = new ContactType
            {
                ID = 1,
                Name = "Put request sucessfull",


            };
            var actResult = controller.Put(1, ContactTypeObj);
            // Act
            var result = actResult as OkNegotiatedContentResult<ContactType>;

            // Assert
            Assert.IsNotNull(result);
            Assert.IsTrue(result.Content.Name.Equals("Put request sucessfull"));
        }



        [TestMethod]
        public void DeleteContactType()
        {
            // Arrange
            ContactTypeController controller = new ContactTypeController();

            var actResult = controller.Delete(1);
            // Act
            var result = actResult as OkNegotiatedContentResult<bool>;

            // Assert
            Assert.IsNotNull(result);
            Assert.IsTrue(result.Content == true);
        }

    }
}
