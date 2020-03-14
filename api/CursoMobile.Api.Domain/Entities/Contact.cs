using CursoMobile.Api.Domain.Enums;
using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.Text;

namespace CursoMobile.Api.Domain.Entities
{
    public class Contact
    {
        [BsonElement("contact_type")]
        public ContactTypeEnum ContactType { get; set; }

        [BsonElement("description")]
        public string Description { get; set; }
    }
}
