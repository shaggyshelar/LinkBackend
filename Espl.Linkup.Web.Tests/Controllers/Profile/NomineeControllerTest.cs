using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

using System.Web.Mvc;
using System.Collections.Generic;
using Espl.Linkup.Web.Controllers.Leaves;
using System.Web.Http.Results;
using Espl.Linkup.Web.Controllers.Profile;
using Espl.Linkup.Domain.Profile.Nominee;

namespace Espl.Linkup.Web.Tests.Controllers
{
    [TestClass]
    public class NomineeControllerTest
    {
        [TestMethod]
        public void getAllNominee()
        {
            // Arrange
            NomineeController controller = new NomineeController();

            var actResult = controller.Get();
            // Act
            var result = actResult as OkNegotiatedContentResult<List<Nominee>>;

            // Assert
            Assert.IsNotNull(result);
            Assert.IsTrue(result.Content.Count >= 1);
        }


        [TestMethod]
        public void getNominee()
        {
            // Arrange
            NomineeController controller = new NomineeController();

            var actResult = controller.Get(1);
            // Act
            var result = actResult as OkNegotiatedContentResult<Nominee>;

            // Assert
            Assert.IsNotNull(result);
            Assert.IsTrue(result.Content.ID == 1);
        }


        [TestMethod]
        public void PostNominee()
        {
            // Arrange
            NomineeController controller = new NomineeController();

            Nominee NomineeObj = new Nominee
                 {
                     FirstNomineeName = "Jhon",
                     FirstNomineeRelationWithEmp="Father",
                 };
            var actResult = controller.Post(NomineeObj);
            // Act
            var result = actResult as OkNegotiatedContentResult<Nominee>;

            // Assert
            Assert.IsNotNull(result);
            Assert.IsTrue(result.Content.ID > 0);
        }



        [TestMethod]
        public void PutNominee()
        {
            // Arrange
            NomineeController controller = new NomineeController();

            Nominee NomineeObj = new Nominee
            {
                FirstNomineeName = "Put request sucessfull",
                ID = 1
            };
            var actResult = controller.Put(1, NomineeObj);
            // Act
            var result = actResult as OkNegotiatedContentResult<Nominee>;

            // Assert
            Assert.IsNotNull(result);
            Assert.IsTrue(result.Content.FirstNomineeName.Equals("Put request sucessfull"));
        }



        [TestMethod]
        public void DeleteNominee()
        {
            // Arrange
            NomineeController controller = new NomineeController();

            var actResult = controller.Delete(1);
            // Act
            var result = actResult as OkNegotiatedContentResult<bool>;

            // Assert
            Assert.IsNotNull(result);
            Assert.IsTrue(result.Content == true);
        }

    }
}
