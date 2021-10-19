using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using UnitTest_Mock.Models;

namespace UnitTest_Mock.Services
{
    public interface IEmployeeService
    {
        string GetEmployeeId(int EmpID);
        Employee GetEmployeeDetails(int EmpID);
    }
}
