using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

using System.Web.Mvc;
using System.Collections.Generic;
using Espl.Linkup.Web.Controllers.Leaves;
using System.Web.Http.Results;
using Espl.Linkup.Web.Controllers.Profile;
using Espl.Linkup.Domain.Profile.Users;
using Espl.Linkup.Domain.PFs;
using Espl.Linkup.Domain.Profile.Contact;

namespace Espl.Linkup.Web.Tests.Controllers
{
    [TestClass]
    public class UserControllerTest
    {
        [TestMethod]
        public void getAllUser()
        {
            // Arrange
            UserController controller = new UserController();

            var actResult = controller.Get();
            // Act
            var result = actResult as OkNegotiatedContentResult<List<User>>;

            // Assert
            Assert.IsNotNull(result);
            Assert.IsTrue(result.Content.Count >= 1);
        }


        [TestMethod]
        public void getUser()
        {
            // Arrange
            UserController controller = new UserController();

            var actResult = controller.Get(1);
            // Act
            var result = actResult as OkNegotiatedContentResult<User>;

            // Assert
            Assert.IsNotNull(result);
            Assert.IsTrue(result.Content.ID == 1);
        }


        [TestMethod]
        public void PostUser()
        {
            // Arrange
            UserController controller = new UserController();

            User UserObj = new User
                 {
                     Name = "Suresh",
                     CurrentAdd = "Ravet",
                     ContactNo = "1234567890",
                     Email = "abc@gmail.com",
                     DOB = new DateTime(1988, 11, 28),
                     PF = new PF { ID = 1, PreviousOrgPFNumber = "123456", CurrentOrgPFNumber = "789456" },
                     CareerStartDate = new DateTime(2012, 11, 28),
                     LastWorkingDayOfPrevEmployer = new DateTime(1988, 11, 27),
                     Contact = new Contact { ID = 1, Name = "Karan", Number = "12569874" },
                     SkypeID = "123"

                 };
            var actResult = controller.Post(UserObj);
            // Act
            var result = actResult as OkNegotiatedContentResult<User>;

            // Assert
            Assert.IsNotNull(result);
            Assert.IsTrue(result.Content.ID > 1);
        }



        [TestMethod]
        public void PutUser()
        {
            // Arrange
            UserController controller = new UserController();

            User UserObj = new User
            {
                Name = "Put request sucessfull",
                CurrentAdd = "Ravet",
                ContactNo = "1234567890",
                Email = "amol@gmail.com",
                DOB = new DateTime(1988, 11, 28),
                PF = new PF { ID = 1, PreviousOrgPFNumber = "123456", CurrentOrgPFNumber = "789456" },
                CareerStartDate = new DateTime(2012, 11, 28),
                LastWorkingDayOfPrevEmployer = new DateTime(1988, 11, 27),
                Contact = new Contact { ID = 1, Name = "Amol", Number = "12569874" },
                SkypeID = "123",
                ID = 1
            };
            var actResult = controller.Put(1, UserObj);
            // Act
            var result = actResult as OkNegotiatedContentResult<User>;

            // Assert
            Assert.IsNotNull(result);
            Assert.IsTrue(result.Content.Name.Equals("Put request sucessfull"));
        }



        [TestMethod]
        public void DeleteUser()
        {
            // Arrange
            UserController controller = new UserController();

            var actResult = controller.Delete(1);
            // Act
            var result = actResult as OkNegotiatedContentResult<bool>;

            // Assert
            Assert.IsNotNull(result);
            Assert.IsTrue(result.Content == true);
        }

    }
}
