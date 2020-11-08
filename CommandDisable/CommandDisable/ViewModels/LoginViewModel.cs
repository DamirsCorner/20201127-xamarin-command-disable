using CommandDisable.Views;
using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace CommandDisable.ViewModels
{
    public class LoginViewModel : BaseViewModel
    {
        private string username;
        private string password;

        public Command LoginCommand { get; }

        public LoginViewModel()
        {
            LoginCommand = new Command(OnLoginClicked, LoginAllowed);
        }

        public string Username
        { 
            get => username;
            set
            {
                SetProperty(ref username, value);
                LoginCommand.ChangeCanExecute();
            }
        }

        public string Password 
        { 
            get => password;
            set
            {
                SetProperty(ref password, value);
                LoginCommand.ChangeCanExecute();
            }
        }

        public bool LoginAllowed(object obj) => !string.IsNullOrEmpty(username) && !string.IsNullOrEmpty(password);

        private async void OnLoginClicked(object obj)
        {
            // Prefixing with `//` switches to a different navigation stack instead of pushing to the active one
            await Shell.Current.GoToAsync($"//{nameof(AboutPage)}");
        }
    }
}
