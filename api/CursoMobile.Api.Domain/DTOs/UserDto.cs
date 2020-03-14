using System;
using System.Collections.Generic;
using System.Text;

namespace CursoMobile.Api.Domain.DTOs
{
    public class UserDto
    {
        public string Id { get; set; }

        public string Name { get; set; }

        public string Cpf { get; set; }

        public DateTime BirthDate { get; set; }

        public AddressDto Address { get; set; }

        public IEnumerable<ContactDto> Contacts { get; set; }
    }
}
