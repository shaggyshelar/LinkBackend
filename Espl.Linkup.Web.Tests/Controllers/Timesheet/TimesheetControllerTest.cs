using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

using System.Web.Mvc;
using System.Collections.Generic;
using Espl.Linkup.Web.Controllers.Leaves;
using System.Web.Http.Results;
using Espl.Linkup.Web.Controllers.Timesheets;
using Espl.Linkup.Domain.Timesheets;
using Espl.Linkup.Domain.Projects;
using Espl.Linkup.Domain.Projects.Tasks;

namespace Espl.Linkup.Web.Tests.Controllers
{
    [TestClass]
    public class TimesheetControllerTest
    {
        [TestMethod]
        public void getAllTimesheet()
        {
            // Arrange
            TimesheetController controller = new TimesheetController();

            var actResult = controller.Get();
            // Act
            var result = actResult as OkNegotiatedContentResult<List<Timesheet>>;

            // Assert
            Assert.IsNotNull(result);
            Assert.IsTrue(result.Content.Count >= 1);
        }


        [TestMethod]
        public void getTimesheet()
        {
            // Arrange
            TimesheetController controller = new TimesheetController();

            var actResult = controller.Get(1);
            // Act
            var result = actResult as OkNegotiatedContentResult<Timesheet>;

            // Assert
            Assert.IsNotNull(result);
            Assert.IsTrue(result.Content.ID == 1);
        }


        [TestMethod]
        public void PostTimesheet()
        {
            // Arrange
            TimesheetController controller = new TimesheetController();

            Timesheet TimesheetObj = new Timesheet
                 {
                     Project = new Project { ID = 2, Name = "Second" },
                     Task = new Task { ID = 1, Project = new Project { ID = 1 }, Name = "Development" },
                     TimesheetGroupID = 1,
                     MondayBNote = "This is sample task for project",
                     TuesdayBNote = "This is sample task for project",
                     WednesdayBNote = "This is sample task for project",
                     ThursdayBNote = "This is sample task for project",
                     FridayBNote = "This is sample task for project",
                     SaturdayBNote = "This is sample task for project",
                     SundayBNote = "This is sample task for project",
                     MondayBTime = new TimeSpan(2, 14, 00),
                     TuesdayBTime = new TimeSpan(2, 14, 00),
                     WednesdayBTime = new TimeSpan(2, 14, 00),
                     ThursdayBTime = new TimeSpan(2, 14, 00),
                     FridayBTime = new TimeSpan(2, 14, 00),
                     SaturdayBTime = new TimeSpan(2, 14, 00),
                     SundayBTime = new TimeSpan(2, 14, 00),
                     MondayNBNote = "This is sample task for project",
                     TuesdayNBNote = "This is sample task for project",
                     WednesdayNBNote = "This is sample task for project",
                     ThursdayNBNote = "This is sample task for project",
                     FridayNBNote = "This is sample task for project",
                     SaturdayNBNote = "This is sample task for project",
                     SundayNBNote = "This is sample task for project",
                     MondayNBTime = new TimeSpan(2, 14, 00),
                     TuesdayNBTime = new TimeSpan(2, 15, 00),
                     WednesdayNBTime = new TimeSpan(2, 16, 00),
                     ThursdayNBTime = new TimeSpan(2, 17, 00),
                     FridayNBTime = new TimeSpan(2, 18, 00),
                     SaturdayNBTime = new TimeSpan(2, 19, 00),
                     SundayNBTime = new TimeSpan(2, 20, 00),
                     MondayDate = new DateTime(2016, 11, 14),
                     TuesdayDate = new DateTime(2016, 11, 15),
                     WednesdayDate = new DateTime(2016, 11, 16),
                     ThursdayDate = new DateTime(2016, 11, 17),
                     FridayDate = new DateTime(2016, 11, 18),
                     SaturdayDate = new DateTime(2016, 11, 19),
                     SundayDate = new DateTime(2016, 11, 20),
                     Status = false,
                 };
            var actResult = controller.Post(TimesheetObj);
            // Act
            var result = actResult as OkNegotiatedContentResult<Timesheet>;

            // Assert
            Assert.IsNotNull(result);
            Assert.IsTrue(result.Content.ID > 2);
        }



        [TestMethod]
        public void PutTimesheet()
        {
            // Arrange
            TimesheetController controller = new TimesheetController();

            Timesheet TimesheetObj = new Timesheet
            {
                Project = new Project { ID = 2, Name = "Second" },
                Task = new Task { ID = 1, Project = new Project { ID = 1 }, Name = "Development" },
                TimesheetGroupID = 1,
                MondayBNote = "Put request sucessfull",
                TuesdayBNote = "This is sample task for project",
                WednesdayBNote = "This is sample task for project",
                ThursdayBNote = "This is sample task for project",
                FridayBNote = "This is sample task for project",
                SaturdayBNote = "This is sample task for project",
                SundayBNote = "This is sample task for project",
                MondayBTime = new TimeSpan(2, 14, 00),
                TuesdayBTime = new TimeSpan(2, 14, 00),
                WednesdayBTime = new TimeSpan(2, 14, 00),
                ThursdayBTime = new TimeSpan(2, 14, 00),
                FridayBTime = new TimeSpan(2, 14, 00),
                SaturdayBTime = new TimeSpan(2, 14, 00),
                SundayBTime = new TimeSpan(2, 14, 00),
                MondayNBNote = "This is sample task for project",
                TuesdayNBNote = "This is sample task for project",
                WednesdayNBNote = "This is sample task for project",
                ThursdayNBNote = "This is sample task for project",
                FridayNBNote = "This is sample task for project",
                SaturdayNBNote = "This is sample task for project",
                SundayNBNote = "This is sample task for project",
                MondayNBTime = new TimeSpan(2, 14, 00),
                TuesdayNBTime = new TimeSpan(2, 15, 00),
                WednesdayNBTime = new TimeSpan(2, 16, 00),
                ThursdayNBTime = new TimeSpan(2, 17, 00),
                FridayNBTime = new TimeSpan(2, 18, 00),
                SaturdayNBTime = new TimeSpan(2, 19, 00),
                SundayNBTime = new TimeSpan(2, 20, 00),
                MondayDate = new DateTime(2016, 11, 14),
                TuesdayDate = new DateTime(2016, 11, 15),
                WednesdayDate = new DateTime(2016, 11, 16),
                ThursdayDate = new DateTime(2016, 11, 17),
                FridayDate = new DateTime(2016, 11, 18),
                SaturdayDate = new DateTime(2016, 11, 19),
                SundayDate = new DateTime(2016, 11, 20),
                Status = false,
                ID = 1
            };
            var actResult = controller.Put(1, TimesheetObj);
            // Act
            var result = actResult as OkNegotiatedContentResult<Timesheet>;

            // Assert
            Assert.IsNotNull(result);
            Assert.IsTrue(result.Content.MondayBNote.Equals("Put request sucessfull"));
        }



        [TestMethod]
        public void DeleteTimesheet()
        {
            // Arrange
            TimesheetController controller = new TimesheetController();

            var actResult = controller.Delete(1);
            // Act
            var result = actResult as OkNegotiatedContentResult<bool>;

            // Assert
            Assert.IsNotNull(result);
            Assert.IsTrue(result.Content == true);
        }

    }
}
