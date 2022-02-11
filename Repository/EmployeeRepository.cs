using Contracts;
using Entities;
using Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Repository
{
    internal class EmployeeRepository : RepositoryBase<Employee>, IEmployeeRepository
    {

        public EmployeeRepository(RepositoryContext repositoryContext) : base(repositoryContext)
        {

        }

        public void CreateEmployeeForCompany(Guid id, Employee employee)
        {
            employee.CompanyId = id;
            Create(employee);
        }

        public void DeleteEmployee(Employee employee)
        {
            Delete(employee);
        }

        public Employee GetEmployee(Guid companyid, Guid id, bool trackChanges) =>
             FindByCondition(e => e.CompanyId.Equals(companyid) && e.Id.Equals(id), trackChanges)
            .SingleOrDefault();

        public IEnumerable<Employee> GetEmployees(Guid companyid, bool trackChanges) =>
             FindByCondition(e => e.CompanyId.Equals(companyid), trackChanges)
            .OrderBy(e => e.Name)
            .ToList();

    }
}