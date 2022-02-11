using Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contracts
{
    public  interface IEmployeeRepository
    {
        IEnumerable<Employee> GetEmployees(Guid companyid, bool trackChanges);
        void CreateEmployeeForCompany(Guid id, Employee employee);
        Employee GetEmployee(Guid companyid, Guid id, bool trackChanges);
        void DeleteEmployee (Employee employee);

    }
}
