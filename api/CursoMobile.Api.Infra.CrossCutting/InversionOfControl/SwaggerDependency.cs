using Microsoft.Extensions.DependencyInjection;
using Microsoft.OpenApi.Models;
using Swashbuckle.AspNetCore.Swagger;
using System;
using System.Collections.Generic;
using System.Text;

namespace CursoMobile.Api.Infra.CrossCutting.InversionOfControl
{
    public static class SwaggerDependency
    {
        public static void AddSwagger(this IServiceCollection services)
        {
            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1",
                    new OpenApiInfo
                    {
                        Title = "Udemy Course",
                        Version = "V1",
                        Description = "Course"
                    });
            });
        }
    }
}
