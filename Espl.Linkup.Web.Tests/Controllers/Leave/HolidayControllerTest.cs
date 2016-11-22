using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

using System.Web.Mvc;
using System.Collections.Generic;
using Espl.Linkup.Web.Controllers.Leaves;
using System.Web.Http.Results;
using Espl.Linkup.Web.Controllers.Leave.Holidays;

namespace Espl.Linkup.Web.Tests.Controllers
{
    [TestClass]
    public class HolidayControllerTest
    {
        [TestMethod]
        public void getAllHoliday()
        {
            // Arrange
            HolidayController controller = new HolidayController();

            var actResult = controller.Get();
            // Act
            var result = actResult as OkNegotiatedContentResult<List<Espl.Linkup.Domain.Leave.Holiday.Holiday>>;

            // Assert
            Assert.IsNotNull(result);
            Assert.IsTrue(result.Content.Count >=2);
        }


        [TestMethod]
        public void getHoliday()
        {
            // Arrange
            HolidayController controller = new HolidayController();

            var actResult = controller.Get(1);
            // Act
            var result = actResult as OkNegotiatedContentResult<Espl.Linkup.Domain.Leave.Holiday.Holiday>;

            // Assert
            Assert.IsNotNull(result);
            Assert.IsTrue(result.Content.ID == 1);
        }


        [TestMethod]
        public void PostHoliday()
        {
            // Arrange
            HolidayController controller = new HolidayController();

            Espl.Linkup.Domain.Leave.Holiday.Holiday HolidayObj = new Espl.Linkup.Domain.Leave.Holiday.Holiday
                 {
                     Title = "Christmas",
                     WeekDay = "Sunday",
                     HolidayType = "Fixed",
                     HolidayDate = new DateTime()

                 };
            var actResult = controller.Post(HolidayObj);
            // Act
            var result = actResult as OkNegotiatedContentResult<Espl.Linkup.Domain.Leave.Holiday.Holiday>;

            // Assert
            Assert.IsNotNull(result);
            Assert.IsTrue(result.Content.ID > 0);
        }



        [TestMethod]
        public void PutHoliday()
        {
            // Arrange
            HolidayController controller = new HolidayController();

            Espl.Linkup.Domain.Leave.Holiday.Holiday HolidayObj = new Espl.Linkup.Domain.Leave.Holiday.Holiday
            {
                ID = 1,
                Title = "Put request sucessfull",
                WeekDay = "Sunday",
                HolidayType = "Fixed",
                HolidayDate = new DateTime()

            };
            var actResult = controller.Post(HolidayObj);
            // Act
            var result = actResult as OkNegotiatedContentResult<Espl.Linkup.Domain.Leave.Holiday.Holiday>;

            // Assert
            Assert.IsNotNull(result);
            Assert.IsTrue(result.Content.Title.Equals("Put request sucessfull"));
        }



        [TestMethod]
        public void DeleteHoliday()
        {
            // Arrange
            HolidayController controller = new HolidayController();

            var actResult = controller.Delete(1);
            // Act
            var result = actResult as OkNegotiatedContentResult<bool>;

            // Assert
            Assert.IsNotNull(result);
            Assert.IsTrue(result.Content== true);
        }

    }
}
