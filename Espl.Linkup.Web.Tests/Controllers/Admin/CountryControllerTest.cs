using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Web.Mvc;
using System.Collections.Generic;
using System.Web.Http.Results;
using Espl.Linkup.Web.Controllers.Corporate;
using Espl.Linkup.Domain.Profile.Users;
using Espl.Linkup.Domain.Departments;
using Espl.Linkup.Domain.Countries;

namespace Espl.Linkup.Web.Tests.Controllers
{
    [TestClass]
    public class CountryControllerTest
    {
        [TestMethod]
        public void getAllCountry()
        {
            // Arrange
            CountryController controller = new CountryController();

            var actResult = controller.Get();
            // Act
            var result = actResult as OkNegotiatedContentResult<List<Country>>;

            // Assert
            Assert.IsNotNull(result);

            Assert.IsTrue(result.Content.Count >= 1);
        }


        [TestMethod]
        public void getCountry()
        {
            // Arrange
            CountryController controller = new CountryController();

            var actResult = controller.Get(1);
            // Act
            var result = actResult as OkNegotiatedContentResult<Country>;

            // Assert
            Assert.IsNotNull(result);
            Assert.IsTrue(result.Content.ID == 1);
        }


        [TestMethod]
        public void PostCountry()
        {
            // Arrange
            CountryController controller = new CountryController();

            Country CountryObj = new Country
            {
                User = new User { ID = 1 },
                Name = "England",
            };
            var actResult = controller.Post(CountryObj);
            // Act
            var result = actResult as OkNegotiatedContentResult<Country>;

            // Assert
            Assert.IsNotNull(result);
            Assert.IsTrue(result.Content.ID > 0);
        }



        [TestMethod]
        public void PutCountry()
        {
            // Arrange
            CountryController controller = new CountryController();

            Country CountryObj = new Country
            {
                User = new User { ID = 1 },
                Name = "Put request sucessfull",
                ID = 1
            };
            var actResult = controller.Put(1, CountryObj);
            // Act
            var result = actResult as OkNegotiatedContentResult<Country>;

            // Assert
            Assert.IsNotNull(result);
            Assert.IsTrue(result.Content.Name.Equals("Put request sucessfull"));
        }



        [TestMethod]
        public void DeleteCountry()
        {
            // Arrange
            CountryController controller = new CountryController();

            var actResult = controller.Delete(1);
            // Act
            var result = actResult as OkNegotiatedContentResult<bool>;

            // Assert
            Assert.IsNotNull(result);
            Assert.IsTrue(result.Content == true);
        }

    }
}
