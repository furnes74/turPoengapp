using Plugin.Geolocator;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Essentials;

namespace turPoeng1._1.Models
{
   public class GeoLoaction{
        protected async void OnAppearing()
        {
            
            await RetriveLocation();
          
          //  online = cCon.IsWeOnline();
           /* txtonline.t
            txtonline.Text = "er vi online " + online.ToString();
            if (viewModel.Items.Count == 0)
                viewModel.LoadItemsCommand.Execute(null);
                */
        }
        public async Task RetriveLocation()
        {

            var locator = CrossGeolocator.Current;
            locator.DesiredAccuracy = 20;

            var position = await locator.GetPositionAsync(TimeSpan.FromSeconds(10), null, true);
            
            checkPosition(position.Latitude, position.Longitude);
           // txtLat.Text = position.Latitude.ToString();
           // txtLong.Text = position.Longitude.ToString();
        }

        private void checkPosition(double latitude, double longitude)
        {
            double posLat = 60.372467;
            double posLong = 5.351656;
            Location veien = new Location(posLat, posLong);
            Location derduer = new Location(latitude, longitude);
            double km = Location.CalculateDistance(veien, derduer, DistanceUnits.Kilometers);
            double m = km * 1000;
            double mto = Math.Round(m, 0);
           // txtres.Text = mto.ToString() + " meter til mål";
        }
    }
}
