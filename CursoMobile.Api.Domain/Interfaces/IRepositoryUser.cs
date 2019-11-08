using CursoMobile.Api.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace CursoMobile.Api.Domain.Interfaces
{
    public interface IRepositoryUser
    {
        Task<IEnumerable<User>> GetAllAsync();

        Task<User> GetByIdAsync(string id);

        Task<User> InsertAsync(User user);

        Task<User> UpdateAsync(User user);

        Task DeleteByIdAsync(string id);
    }
}
