using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using UnitTest_Mock.Services;
using UnitTest_Mock.Models;

namespace UnitTest_Mock.Controllers
{
    public class EmployeeController : ControllerBase
    {
        private readonly IEmployeeService _employeeService;

        public EmployeeController(IEmployeeService employeeService)
        {
            _employeeService = employeeService;
        }

        [HttpGet(nameof(GetEmployeeById))]
        public string GetEmployeeById(int EmpID)
        {
            var result = _employeeService.GetEmployeeId(EmpID);
            return result;
        }

        [HttpGet(nameof(GetEmployeeDetails))]
        public Employee GetEmployeeDetails(int EmpID)
        {
            var res = _employeeService.GetEmployeeDetails(EmpID);
            return res;
        }
    }
}
