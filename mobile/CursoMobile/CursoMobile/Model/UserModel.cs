using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Text;

namespace CursoMobile.Model
{
    public class UserModel
    {
        public UserModel()
        {
            Address = new AddressModel();
            Contacts = new ObservableCollection<ContactModel>();
            Contacts.Add(new ContactModel());
        }

        public string Id { get; set; }

        public string Name { get; set; }

        public DateTime BirthDate { get; set; }

        public AddressModel Address { get; set; }

        public ObservableCollection<ContactModel> Contacts { get; set; }
    }
}
