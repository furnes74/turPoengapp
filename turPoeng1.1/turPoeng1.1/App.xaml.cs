using System;
using turPoeng1.Services;
using turPoeng1.Views;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;


namespace turPoeng1
{
    public partial class App : Application
    {

        public App()
        {
            InitializeComponent();

            DependencyService.Register<MockDataStore>();
            MainPage = new MainPage();
        }

        private void InitializeComponent()
        {
           
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
