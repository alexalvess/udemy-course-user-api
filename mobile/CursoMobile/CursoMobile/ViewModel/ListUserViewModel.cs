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
        const string url = "";

        private IList<UserModel> users;
        private ICommand goToInsertPage;
        private ICommand goToDetailPage;

        public ListUserViewModel() =>
            ListUsers();

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

        private async void ListUsers()
        {
            var userApi = RestService.For<IUserApi>(url);
            Users = await userApi.List();
        }
    }
}
