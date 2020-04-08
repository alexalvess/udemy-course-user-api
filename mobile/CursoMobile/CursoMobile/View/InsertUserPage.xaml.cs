using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CursoMobile.Model;
using CursoMobile.ViewModel;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace CursoMobile.View
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class InsertUserPage : ContentPage
    {
        public InsertUserPage()
        {
            InitializeComponent();

            BindingContext = new InsertUserViewModel();
        }
    }
}