using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using AutoMapper;
using JoeMovies.Dtos;
using JoeMovies.Models;

namespace JoeMovies.App_Start
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            Mapper.CreateMap<Customer,CustomerDto>();
            Mapper.CreateMap<CustomerDto, Customer>();
        }
    }
}