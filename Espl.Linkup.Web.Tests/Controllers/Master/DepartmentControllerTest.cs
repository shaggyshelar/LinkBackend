using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

using System.Web.Mvc;
using System.Collections.Generic;
using Espl.Linkup.Web.Controllers.Leaves;
using System.Web.Http.Results;
using Espl.Linkup.Web.Controllers.Master;
using Espl.Linkup.Domain.Departments;

namespace Espl.Linkup.Web.Tests.Controllers
{
    [TestClass]
    public class DepartmentControllerTest
    {
        [TestMethod]
        public void getAllDepartment()
        {
            // Arrange
            DepartmentController controller = new DepartmentController();

            var actResult = controller.Get();
            // Act
            var result = actResult as OkNegotiatedContentResult<List<Department>>;

            // Assert
            Assert.IsNotNull(result);
            Assert.IsTrue(result.Content.Count >= 2);
        }


        [TestMethod]
        public void getDepartment()
        {
            // Arrange
            DepartmentController controller = new DepartmentController();

            var actResult = controller.Get(1);
            // Act
            var result = actResult as OkNegotiatedContentResult<Department>;

            // Assert
            Assert.IsNotNull(result);
            Assert.IsTrue(result.Content.ID == 1);
        }


        [TestMethod]
        public void PostDepartment()
        {
            // Arrange
            DepartmentController controller = new DepartmentController();

            Department DepartmentObj = new Department
                 {
                     Name = "EBS"

                 };
            var actResult = controller.Post(DepartmentObj);
            // Act
            var result = actResult as OkNegotiatedContentResult<Department>;

            // Assert
            Assert.IsNotNull(result);
            Assert.IsTrue(result.Content.ID > 0);
        }



        [TestMethod]
        public void PutDepartment()
        {
            // Arrange
            DepartmentController controller = new DepartmentController();

            Department DepartmentObj = new Department
            {
                ID = 1,
                Name = "Put request sucessfull",


            };
            var actResult = controller.Put(1, DepartmentObj);
            // Act
            var result = actResult as OkNegotiatedContentResult<Department>;

            // Assert
            Assert.IsNotNull(result);
            Assert.IsTrue(result.Content.Name.Equals("Put request sucessfull"));
        }



        [TestMethod]
        public void DeleteDepartment()
        {
            // Arrange
            DepartmentController controller = new DepartmentController();

            var actResult = controller.Delete(1);
            // Act
            var result = actResult as OkNegotiatedContentResult<bool>;

            // Assert
            Assert.IsNotNull(result);
            Assert.IsTrue(result.Content == true);
        }

    }
}
