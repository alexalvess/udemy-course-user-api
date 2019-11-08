using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.Text;

namespace CursoMobile.Api.Domain.Entities
{
    public class User : BaseEntity
    {
        [BsonElement("name")]
        public string Name { get; set; }

        [BsonElement("cpf")]
        public string Cpf { get; set; }

        [BsonElement("birth_date")]
        public DateTime BirthDate { get; set; }

        [BsonElement("address")]
        public Address Address { get; set; }

        [BsonElement("contacts")]
        public IEnumerable<Contact> Contacts { get; set; }
    }
}
