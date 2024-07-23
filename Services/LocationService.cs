using LocationTracker.Data;
using LocationTracker.Interfaces;
using LocationTracker.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace LocationTracker.Services
{
    public class LocationService : ILocationService
    {
        private readonly AppDbContext _appDbContext;
        public LocationService(AppDbContext appDbContext) 
        {
            _appDbContext = appDbContext;
        }

        public async Task<Location> SaveLocation(Location location)
        {
            _appDbContext.Locations.Add(location);
            await _appDbContext.SaveChangesAsync();
            return location;
        }

        public async Task<IEnumerable<Location>> GetLocation()
        {
            return await _appDbContext.Locations.ToListAsync();
        }
    }
}
