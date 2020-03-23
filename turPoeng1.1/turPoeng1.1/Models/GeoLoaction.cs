using Plugin.Geolocator;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Essentials;

namespace turPoeng1.Models
{
    public class GeoLoaction
    {
        public async Task RetriveLocation()
        {

            var locator = CrossGeolocator.Current;
            locator.DesiredAccuracy = 20;

            var position = await locator.GetPositionAsync(TimeSpan.FromSeconds(10), null, true);

            //checkPosition(position.Latitude, position.Longitude);

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

         //Hvor langt Nord skal vi slå opp, 2 km er default
        public double getMaxNorth(int km)
        {
            double maxNorth = 0.020740000000003533; //2 km nord
            return maxNorth;
        }
        //Hvor langt sør skal vi slå opp, 2 km er default
        public double getMinSouth(int km)
        {
            double maxSouth = 0.01821999999999946; // 2 km sør
            return maxSouth;
        }
        //Hvor langt vest skal vi slå opp, 2 km er default
        public double getMaxWest(int km)
        {
            double maxWest = 0.03758999999999979; // 2 km west
            return maxWest;
        }
        //Hvor langt øst skal vi slå opp, 2 km er default
        public double getMinEast(int km)
        {
            double MaxEast = 0.03730000000000011; // 2 km øst
            return MaxEast;
        }
 /*       public bool Between(this double num, double lower, double upper, bool inclusive = false)
        {
            return inclusive
              ? lower <= num && num <= upper
              : lower < num && num < upper;
        }
        */

    }
}
