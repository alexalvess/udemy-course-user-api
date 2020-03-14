using Refit;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace CursoMobile.Model.Interfaces
{
    public interface IUserApi
    {
        [Get("/")]
        Task<IList<UserModel>> List();

        [Post("{user}")]
        Task<UserModel> Insert(UserModel user);

        [Delete("{id}")]
        Task Delete(int id);
    }
}
