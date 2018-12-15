using System;
using System.Threading;
using System.Threading.Tasks;

namespace GPS
{
    public interface ILocationService
    {
        Task<Location> GetLocationAsync();
        Task<Location> GetLocationAsync(CancellationToken cancellationToken);
    }
}
