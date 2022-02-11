using AutoMapper;
using Entities.DataTransferObjects;
using Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CompanyEmployeeAPI
{
    public class MappingProfile:Profile
    {

        public MappingProfile()
        {
            CreateMap<Company, CompanyDto>()
                .ForMember(c => c.Address, opt => opt.MapFrom(x => string.Join("'", x.Address, x.Country)));

            CreateMap<EmployeeDto, Employee>();
            CreateMap<CompanyForCreationDto, Company>();
            CreateMap<EmployeeForCreationDto, Employee>();
            CreateMap<EmployeeForUpdateDto, Employee>().ReverseMap();
            CreateMap<CompanyForUpdateDto, Company>();

        }
    }
}
