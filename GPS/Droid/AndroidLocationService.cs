using System;
using System.Threading;
using System.Threading.Tasks;

namespace GPS.Droid
{
    public class AndroidLocationService : ILocationService
    {
        public Task<Location> GetLocationAsync()
        {
            return GetLocationAsync(CancellationToken.None);
        }

        public async Task<Location> GetLocationAsync(CancellationToken cancellationToken)
        {
            var locator = Plugin.Geolocator.CrossGeolocator.Current;
            locator.DesiredAccuracy = 100;

            var position = await locator.GetPositionAsync(TimeSpan.FromSeconds(10), cancellationToken);


            return new Location(position.Latitude, position.Longitude);


        }
    }
}
