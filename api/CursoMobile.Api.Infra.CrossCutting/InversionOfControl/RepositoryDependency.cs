using CursoMobile.Api.Domain.Interfaces;
using CursoMobile.Api.Infra.Data.Repositories;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Text;

namespace CursoMobile.Api.Infra.CrossCutting.InversionOfControl
{
    public static class RepositoryDependency
    {
        public static void AddRepositories(this IServiceCollection services)
        {
            services.AddScoped<IRepositoryUser, UserRepository>();
        }
    }
}
