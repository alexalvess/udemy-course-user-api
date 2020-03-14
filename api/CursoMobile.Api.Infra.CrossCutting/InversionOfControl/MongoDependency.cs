using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Text;

namespace CursoMobile.Api.Infra.CrossCutting.InversionOfControl
{
    public static class MongoDependency
    {
        public static void AddMongo(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddScoped<IMongoDatabase>(c =>
            {
                var connectionString = configuration.GetSection("MongoDB:connectionString").Value;
                var database = configuration.GetSection("MongoDB:database").Value;

                var client = new MongoClient(connectionString);

                return client.GetDatabase(database);
            });
        }
    }
}
