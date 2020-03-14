using MongoDB.Bson.Serialization.Attributes;
using MongoDB.Bson.Serialization.IdGenerators;
using System;
using System.Collections.Generic;
using System.Text;

namespace CursoMobile.Api.Domain.Entities
{
    public abstract class BaseEntity
    {
        [BsonElement("_id")]
        [BsonId(IdGenerator = typeof(StringObjectIdGenerator))]
        public virtual string Id { get; set; }
    }
}
