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
        const string url = "";

        private UserModel user;
        private ICommand insertCommand;

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

        public ICommand InsertCommand => insertCommand ?? (insertCommand = new Command(async () =>
        {
            var userApi = RestService.For<IUserApi>(url);
            await userApi.Insert(User);

            await PopAsync();
        }));
    }
}
