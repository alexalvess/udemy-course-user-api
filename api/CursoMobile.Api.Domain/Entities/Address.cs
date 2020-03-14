using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.Text;

namespace CursoMobile.Api.Domain.Entities
{
    public class Address
    {
        [BsonElement("zip_code")]
        public string ZipCode { get; set; }

        [BsonElement("number")]
        public string Number { get; set; }

        [BsonElement("street")]
        public string Street { get; set; }

        [BsonElement("neighborhood")]
        public string Neighborhood { get; set; }

        [BsonElement("city")]
        public string City { get; set; }

        [BsonElement("province")]
        public string Province { get; set; }

        [BsonElement("country")]
        public string Country { get; set; }
    }
}
