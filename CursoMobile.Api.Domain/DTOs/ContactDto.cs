using CursoMobile.Api.Domain.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace CursoMobile.Api.Domain.DTOs
{
    public class ContactDto
    {
        public ContactTypeEnum ContactType { get; set; }

        public string Description { get; set; }
    }
}
