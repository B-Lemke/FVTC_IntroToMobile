using System;
namespace GPS
{
    public interface ILocationService
    {
        Task<Location> GetLocationAsync();
    }
}
