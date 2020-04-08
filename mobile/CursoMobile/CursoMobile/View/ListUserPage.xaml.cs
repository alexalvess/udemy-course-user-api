using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CursoMobile.ViewModel;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace CursoMobile.View
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ListUserPage : ContentPage
    {
        public ListUserPage()
        {
            InitializeComponent();

            BindingContext = new ListUserViewModel();
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();

            (BindingContext as ListUserViewModel).ListUsers();
        }
    }
}