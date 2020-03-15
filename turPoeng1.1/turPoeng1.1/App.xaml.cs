using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using turPoeng1._1.Services;
using turPoeng1._1.Views;

namespace turPoeng1._1
{
    public partial class App : Application
    {

        public App()
        {
            InitializeComponent();

            DependencyService.Register<MockDataStore>();
            MainPage = new MainPage();
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
