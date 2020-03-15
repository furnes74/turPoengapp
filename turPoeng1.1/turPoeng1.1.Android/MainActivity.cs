using System;

using Android.App;
using Android.Content.PM;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.OS;
using System.Threading.Tasks;
using Plugin.Geolocator;
using Android.Util;

namespace turPoeng1._1.Droid
{
    [Activity(Label = "turPoeng1._1", Icon = "@mipmap/icon", Theme = "@style/MainTheme", ConfigurationChanges = ConfigChanges.ScreenSize | ConfigChanges.Orientation)]
    public class MainActivity : global::Xamarin.Forms.Platform.Android.FormsAppCompatActivity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            TabLayoutResource = Resource.Layout.Tabbar;
            ToolbarResource = Resource.Layout.Toolbar;
           
            base.OnCreate(savedInstanceState);

            Xamarin.Essentials.Platform.Init(this, savedInstanceState);
            global::Xamarin.Forms.Forms.Init(this, savedInstanceState);
            LoadApplication(new App());
        }
        public override void OnRequestPermissionsResult(int requestCode, string[] permissions, [GeneratedEnum] Android.Content.PM.Permission[] grantResults)
        {
            Xamarin.Essentials.Platform.OnRequestPermissionsResult(requestCode, permissions, grantResults);

            base.OnRequestPermissionsResult(requestCode, permissions, grantResults);
        }
        private async Task RetriveLocation()
        {

            var locator = CrossGeolocator.Current;
            
            locator.DesiredAccuracy = 30;

            var position = await locator.GetPositionAsync(TimeSpan.FromSeconds(10), null, true);
            Log.Debug("Posision", "Latitude:" + position.Latitude.ToString());
            Log.Debug("Posision", "Longitude:" + position.Longitude.ToString());
            /* checkPosition(position.Latitude, position.Longitude);
             txtLat.Text = position.Latitude.ToString();
             txtLong.Text = position.Longitude.ToString();
             */
        }
    }
}