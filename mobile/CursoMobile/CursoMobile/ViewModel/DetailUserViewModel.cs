using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;
using CursoMobile.Model;
using CursoMobile.Model.Interfaces;
using Refit;
using Xamarin.Forms;

namespace CursoMobile.ViewModel
{
    public class DetailUserViewModel : BaseViewModel
    {
        private UserModel userModel;

        private ICommand removeUser;

        public DetailUserViewModel(UserModel userModel) =>
            User = userModel;

        public UserModel User
        {
            get => userModel;
            set
            {
                userModel = value;

                if (userModel == null)
                    return;

                OnPropertyChanged("User");
            }
        }

        public ICommand RemoveUser => removeUser ?? (removeUser = new Command(async () =>
        {
            var userApi = RestService.For<IUserApi>(url);
            await userApi.Delete(User.Id);

            await PopAsync();
        }));
    }
}
