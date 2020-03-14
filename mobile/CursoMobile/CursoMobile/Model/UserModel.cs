using System;
using System.Collections.Generic;
using System.Text;

namespace CursoMobile.Model
{
    public class UserModel
    {
        public string Id { get; set; }

        public string Name { get; set; }

        public DateTime BirthDate { get; set; }

        public AddressModel Address { get; set; }

        public IEnumerable<ContactModel> Contacts { get; set; }
    }
}
