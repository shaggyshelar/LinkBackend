using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

using System.Web.Mvc;
using System.Collections.Generic;
using Espl.Linkup.Web.Controllers.Leaves;
using System.Web.Http.Results;
using Espl.Linkup.Web.Controllers.Corporate;
using Espl.Linkup.Domain.Corporate.Ticket;
using Espl.Linkup.Domain.Profile.Users;
using Espl.Linkup.Domain.Departments;


namespace Espl.Linkup.Web.Tests.Controllers
{
    [TestClass]
    public class TicketControllerTest
    {
        [TestMethod]
        public void getAllTicket()
        {
            // Arrange
            TicketController controller = new TicketController();

            var actResult = controller.Get();
            // Act
            var result = actResult as OkNegotiatedContentResult<List<Ticket>>;

            // Assert
            Assert.IsNotNull(result);

            Assert.IsTrue(result.Content.Count >= 1);
        }


        [TestMethod]
        public void getTicket()
        {
            // Arrange
            TicketController controller = new TicketController();

            var actResult = controller.Get(1);
            // Act
            var result = actResult as OkNegotiatedContentResult<Ticket>;

            // Assert
            Assert.IsNotNull(result);
            Assert.IsTrue(result.Content.ID == 1);
        }


        [TestMethod]
        public void PostTicket()
        {
            // Arrange
            TicketController controller = new TicketController();

            Ticket TicketObj = new Ticket
            {
                User = new User { ID = 1 },
                Concern = "Software Installation",
                Department = new Department { ID = 1, Name = "EBS" },
                Description = "Not able to connect with bit bucket",
                Priority = Espl.Linkup.Domain.Enums.Enum.Priority.High,
                CreatedOn = new DateTime(2016, 10, 10),
                Status = "Closed",
                Isclosed = true,
                IsReopen = true,
            };
            var actResult = controller.Post(TicketObj);
            // Act
            var result = actResult as OkNegotiatedContentResult<Ticket>;

            // Assert
            Assert.IsNotNull(result);
            Assert.IsTrue(result.Content.ID > 0);
        }



        [TestMethod]
        public void PutTicket()
        {
            // Arrange
            TicketController controller = new TicketController();

            Ticket TicketObj = new Ticket
            {
                User = new User { ID = 1 },
                Concern = "Put request sucessfull",
                Department = new Department { ID = 1, Name = "EBS" },
                Description = "Not able to connect with bit bucket",
                Priority = Espl.Linkup.Domain.Enums.Enum.Priority.High,
                CreatedOn = new DateTime(2016, 10, 10),
                Status = "Closed",
                Isclosed = true,
                IsReopen = true,
                ID = 1
            };
            var actResult = controller.Put(1, TicketObj);
            // Act
            var result = actResult as OkNegotiatedContentResult<Ticket>;

            // Assert
            Assert.IsNotNull(result);
            Assert.IsTrue(result.Content.Concern.Equals("Put request sucessfull"));
        }



        [TestMethod]
        public void DeleteTicket()
        {
            // Arrange
            TicketController controller = new TicketController();

            var actResult = controller.Delete(1);
            // Act
            var result = actResult as OkNegotiatedContentResult<bool>;

            // Assert
            Assert.IsNotNull(result);
            Assert.IsTrue(result.Content == true);
        }

    }
}
