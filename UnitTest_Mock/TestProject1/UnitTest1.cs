using System;
using Xunit;
using UnitTest_Mock.Controllers;
using UnitTest_Mock.Models;
using UnitTest_Mock.Services;
using Moq;

namespace TestProject1
{
    public class UnitTest1
    {
        public Mock<IEmployeeService> mock = new Mock<IEmployeeService>();

        [Fact]
        public void GetEmployeebyId()
        {
            mock.Setup(p => p.GetEmployeeId(1)).Returns("JK");
            EmployeeController emp = new EmployeeController(mock.Object);
            string res = emp.GetEmployeeById(1);
            Assert.Equal("JK", res);
        }

        [Fact]
        public void GetEmployeeDetails()
        {
            var employeeDTO = new Employee()
            {
                Id = 1,
                Name = "JK",
                Designation = "SDE"
            };

            mock.Setup(p => p.GetEmployeeDetails(1)).Returns(employeeDTO);

            EmployeeController emp = new EmployeeController(mock.Object);
            var res = emp.GetEmployeeDetails(1);
            Assert.True(employeeDTO.Equals(res));
        }
    }
}
