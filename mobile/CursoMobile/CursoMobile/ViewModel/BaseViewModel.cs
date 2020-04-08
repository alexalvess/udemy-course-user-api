using Acr.UserDialogs;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace CursoMobile.ViewModel
{
    public class BaseViewModel : INotifyPropertyChanged
    {
        protected const string url = "https://udemy-course-api.azurewebsites.net/api";

        public event PropertyChangedEventHandler PropertyChanged;
        
        public event Xamarin.Forms.PropertyChangingEventHandler PropertyChanging;

        public IUserDialogs Dialog { get; set; }

        public BaseViewModel() =>
            Dialog = UserDialogs.Instance;

        public async Task PushModalAsync(Page page)
        {
            if (App.Navigation != null)
                await App.Navigation.PushModalAsync(page);
        }

        public async Task PopModalAsync()
        {
            if (App.Navigation != null)
                await App.Navigation.PopModalAsync();
        }

        public async Task PushAsync(Page page)
        {
            if (App.Navigation != null)
                await App.Navigation.PushAsync(page);
        }

        public async Task PopAsync()
        {
            if (App.Navigation != null)
                await App.Navigation.PopAsync();
        }

        public void OnPropertyChanged(string propertyName)
        {
            if (PropertyChanged == null)
                return;

            PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
        }

        public void OnPropertyChanging(string propertyName)
        {
            if (PropertyChanging == null)
                return;

            PropertyChanging(this, new Xamarin.Forms.PropertyChangingEventArgs(propertyName));
        }
    }
}
