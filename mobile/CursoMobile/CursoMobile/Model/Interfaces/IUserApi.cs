using Refit;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace CursoMobile.Model.Interfaces
{
    public interface IUserApi
    {
        [Get("/User")]
        Task<IList<UserModel>> List();

        [Post("/User")]
        Task<UserModel> Insert([Body] UserModel user);

        [Delete("/User/{id}")]
        Task Delete(string id);
    }
}
