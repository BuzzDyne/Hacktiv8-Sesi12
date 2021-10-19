using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using UnitTest_Mock.Models;


namespace UnitTest_Mock.Services
{
    public class EmployeeService : IEmployeeService
    {
        private readonly ApiDbContext _apiDbContext;

        public EmployeeService(ApiDbContext apiDbContext)
        {
            _apiDbContext = apiDbContext;
        }

        public string GetEmployeeId(int EmpID)
        {
            var name = _apiDbContext.Employees.Where(c => c.Id == EmpID).Select(d => d.Name).FirstOrDefault();

            return name;
        }

        public Employee GetEmployeeDetails(int EmpID)
        {
            var emp = _apiDbContext.Employees.FirstOrDefault(c => c.Id == EmpID);

            return emp;
        }

    }
}
