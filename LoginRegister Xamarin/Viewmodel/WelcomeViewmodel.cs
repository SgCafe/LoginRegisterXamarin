using LoginRegister_Xamarin.View;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;

namespace LoginRegister_Xamarin.Viewmodel
{
    public class WelcomeViewmodel : BaseViewmodel
    {
        #region properties
        public INavigation Navigation;
        #endregion

        #region constructor
        public WelcomeViewmodel(INavigation navigation)
        {
            Navigation = navigation;
            GoToLoginPageCommand = new Command(ExecuteGoToLoginPageCommand);
            GoToRegisterPageCommand = new Command(ExecuteGoToRegisterPageCommand);
        }
        #endregion

        #region commands
        public ICommand GoToLoginPageCommand { get; set; }
        public ICommand GoToRegisterPageCommand { get; set; }

        #endregion

        #region methods
        private async void ExecuteGoToLoginPageCommand()
        {
            await Navigation.PushAsync(new LoginPage());
        }

        private async void ExecuteGoToRegisterPageCommand()
        {
            await Navigation.PushAsync(new RegistrationPage());
        }
        #endregion
    }
}
