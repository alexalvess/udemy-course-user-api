using CursoMobile.Model;
using CursoMobile.Model.Interfaces;
using CursoMobile.View;
using Refit;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;

namespace CursoMobile.ViewModel
{
    public class ListUserViewModel : BaseViewModel
    {
        private IList<UserModel> users;
        private UserModel user;
        private ICommand goToInsertPage;
        private ICommand goToDetailPage;

        public IList<UserModel> Users
        {
            get => users;
            set
            {
                users = value;

                if (users == null)
                    return;

                OnPropertyChanged("Users");
            }
        }

        public UserModel User
        {
            get => user;
            set
            {
                user = value;

                if (user == null)
                    return;

                GoToDetailPage.Execute(user);

                OnPropertyChanged("User");

                User = null;
            }
        }

        public ICommand GoToInsertPage => goToInsertPage ?? (goToInsertPage = new Command(async () =>
        {
            var page = new InsertUserPage();
            await PushAsync(page);
        }));

        public ICommand GoToDetailPage => goToDetailPage ?? (goToDetailPage = new Command<UserModel>(async (UserModel user) =>
        {
            var page = new DetailUserPage(user);
            await PushAsync(page);
        }));

        public async void ListUsers()
        {
            Dialog.ShowLoading("Loading...");
            var userApi = RestService.For<IUserApi>(url);
            Users = await userApi.List();
            Dialog.HideLoading();
        }
    }
}
