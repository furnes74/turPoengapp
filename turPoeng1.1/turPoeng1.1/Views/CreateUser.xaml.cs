using System;
using System.ComponentModel;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace turPoeng1.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class CreateUser : ContentPage
    {
        public CreateUser()
        {
            InitializeComponent();
        }

        private void OnEntryTextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void OnEntryCompleted(object sender, EventArgs e)
        {

        }
    }
}