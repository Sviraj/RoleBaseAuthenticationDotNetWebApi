using LocationTracker.Models;

namespace LocationTracker.Interfaces
{
    public interface ILocationService
    {
        Task<Location> SaveLocation(Location location);
        Task<IEnumerable<Location>> GetLocation();
    }
}
