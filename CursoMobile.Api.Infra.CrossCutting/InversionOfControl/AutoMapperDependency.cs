using AutoMapper;
using CursoMobile.Api.Domain.DTOs;
using CursoMobile.Api.Domain.Entities;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Text;

namespace CursoMobile.Api.Infra.CrossCutting.InversionOfControl
{
    public static class AutoMapperDependency
    {
        public static void AddAutoMapper(this IServiceCollection services)
        {
            var config = new MapperConfiguration(c =>
            {
                c.CreateMap<UserDto, User>();
                c.CreateMap<User, UserDto>();

                c.CreateMap<AddressDto, Address>();
                c.CreateMap<Address, AddressDto>();

                c.CreateMap<ContactDto, Contact>();
                c.CreateMap<Contact, ContactDto>();
            });

            IMapper mapper = config.CreateMapper();

            services.AddSingleton(mapper);
        }
    }
}
