using CursoMobile.Model;
using CursoMobile.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace CursoMobile.View
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class DetailUserPage : ContentPage
    {
        public DetailUserPage(UserModel user)
        {
            InitializeComponent();

            BindingContext = new DetailUserViewModel(user);
        }
    }
}