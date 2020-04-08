using CursoMobile.Model;
using CursoMobile.Model.Interfaces;
using Refit;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;

namespace CursoMobile.ViewModel
{
    public class InsertUserViewModel : BaseViewModel
    {
        private UserModel user;
        private ICommand insertCommand;
        private ICommand addContactCommand;
        private ICommand removeContactCommand;

        public InsertUserViewModel() =>
            User = new UserModel();

        public UserModel User
        {
            get => user;
            set
            {
                user = value;

                if (user == null)
                    return;

                OnPropertyChanged("User");
            }
        }

        public ICommand AddContactCommand => addContactCommand ?? (addContactCommand = new Command(() =>
        {
            User.Contacts.Add(new ContactModel());
        }));

        public ICommand RemoveContactCommand => removeContactCommand ?? (removeContactCommand = new Command<ContactModel>((contact) =>
        {
            User.Contacts.Remove(contact);
        }));

        public ICommand InsertCommand => insertCommand ?? (insertCommand = new Command(async () =>
        {
            var userApi = RestService.For<IUserApi>(url);
            await userApi.Insert(User);

            await PopAsync();
        }));
    }
}
