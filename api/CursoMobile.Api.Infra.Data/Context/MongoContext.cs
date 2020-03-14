using CursoMobile.Api.Domain.Entities;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Text;

namespace CursoMobile.Api.Infra.Data.Context
{
    public class MongoContext<T> where T : BaseEntity
    {
        private readonly IMongoDatabase _database;
        private readonly string _collection;

        public MongoContext(IMongoDatabase database, string collection)
        {
            _database = database;
            _collection = collection;
        }

        public IMongoCollection<T> Collection =>
            _database.GetCollection<T>(_collection);
    }
}
