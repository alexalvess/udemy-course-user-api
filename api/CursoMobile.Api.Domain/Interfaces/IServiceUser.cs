using CursoMobile.Api.Domain.DTOs;
using CursoMobile.Api.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace CursoMobile.Api.Domain.Interfaces
{
    public interface IServiceUser
    {
        Task<IEnumerable<UserDto>> Get();

        Task<UserDto> Add(UserDto user);

        Task Delete(string id);
    }
}
