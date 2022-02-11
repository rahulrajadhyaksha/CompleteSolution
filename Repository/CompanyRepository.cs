using Contracts;
using Entities;
using Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Repository
{
    public class CompanyRepository : RepositoryBase<Company>, ICompanyRepository
    {
        public CompanyRepository(RepositoryContext repositoryContext):base(repositoryContext)
        {

        }
        public void CreateCompany(Company company)
        {
            Create(company);
        }

        public void DeleteCompany(Company company)
        {
            Delete(company);
        }

        public IEnumerable<Company> GetAllCompanies(bool trackChanges) =>
            FindAll(trackChanges)
            .OrderBy(c => c.Name)
            .ToList();


        public IEnumerable<Company> GetByIds(IEnumerable<Guid> ids, bool trackchanges) =>
            FindByCondition(x => ids.Contains(x.Id), trackchanges)
            .ToList();

        public Company GetCompany(Guid companyid, bool trackChanges) =>
       FindByCondition(c => c.Id.Equals(companyid), trackChanges)
            .SingleOrDefault();
    }
}