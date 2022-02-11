using Entities.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Configuration
{
    public class EmployeeConfiguration : IEntityTypeConfiguration<Employee>
    {
        public void Configure(EntityTypeBuilder<Employee> builder)
        {
            builder.HasData(
                new Employee
                {
                    Id=new Guid("86dba8c0-d178-41e7-938c-ed49778fb52a"), 
                    Age=30,
                    CompanyId=new Guid("c9d4c053-49b6-410c-bc78-2d54a9991870"), 
                    Name="Jana McLeaf", 
                    Position="Software developer" 
                },
                new  Employee
                {
                    Id= new Guid("021ca3c1-0deb-4afd-ae94-2159a8479811"), 
                    Age=35, 
                    CompanyId= new Guid("3d490a70-94ce-4d15-9494-5248280c2ce3"), 
                    Name="Kane Miller", 
                    Position="Administrator"
                }
                );
        }
    }
}
