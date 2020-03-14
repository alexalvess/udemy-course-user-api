using CursoMobile.Api.Domain.Entities;
using CursoMobile.Api.Domain.Interfaces;
using CursoMobile.Api.Infra.Data.Context;
using MongoDB.Bson;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace CursoMobile.Api.Infra.Data.Repositories
{
    public class UserRepository : IRepositoryUser
    {
        private readonly MongoContext<User> context;

        public UserRepository(IMongoDatabase database) =>
            context = new MongoContext<User>(database, "user");

        public async Task DeleteByIdAsync(string id) =>
            await context.Collection.DeleteOneAsync(d => d.Id == id);

        public async Task<IEnumerable<User>> GetAllAsync() =>
            await context.Collection.AsQueryable().ToListAsync();

        public async Task<User> GetByIdAsync(string id) =>
            (await context.Collection.FindAsync(f => f.Id == id)).FirstOrDefault();

        public async Task<User> InsertAsync(User user)
        {
            await context.Collection.InsertOneAsync(user);
            return user;
        }

        public async Task<User> UpdateAsync(User user) =>
            await context.Collection.FindOneAndReplaceAsync(new BsonDocument("_id", user.Id), user);
    }
}
