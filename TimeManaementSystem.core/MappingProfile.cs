using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TimeManaementSystem.Core.Entities;
using TimeManagementSystem.Core.DTOs;

namespace TimeManagementSystem.Core
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<User, UserDto>().ReverseMap();
            CreateMap<WorkHours, WorkHoursDto>().ReverseMap();
        }
    }
}
