using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ThingsToDoProject.Model;
using GoogleMaps.LocationServices;

namespace ThingsToDoProject.DataAccess
{
    public static class GetLatitudeLongitudeOfParticularCity
    {
        public static Location GetLatitudeLogitude(string CityName)
        {
            //String paremeter that provides the google map api key
            Location Position = new Location();
            Position.Address = CityName;
            var locationService = new GoogleLocationService(apikey: "YOURAPIKEY");
            var Point = locationService.GetLatLongFromAddress(Position.Address);

            Position.LatitudePosition = Point.Latitude;
            Position.LongitudePosition = Point.Longitude;

            return Position;
        }
    }
}
