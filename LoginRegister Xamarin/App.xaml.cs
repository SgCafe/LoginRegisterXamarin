using LoginRegister_Xamarin.Service;
using LoginRegister_Xamarin.View;
using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace LoginRegister_Xamarin
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new MainPage();
            DependencyService.Register<ILoginService, LoginService>();
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
