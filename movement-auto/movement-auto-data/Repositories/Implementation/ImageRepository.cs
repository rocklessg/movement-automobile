using Microsoft.EntityFrameworkCore;
using movement_auto_data.DbContexts;
using movement_auto_data.Repositories.Abstraction;
using movement_auto_models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace movement_auto_data.Repositories.Implementation
{
    public class ImageRepository : IImageRepository
    {
        private readonly MovementDbContext _context;

        public ImageRepository(MovementDbContext context)
        {
            _context = context;
        }
        public async Task<IEnumerable<Image>> GetImages(string vehicleId)
        {
            return await _context.Images.Where(i => i.VehicleId == vehicleId)
                .ToListAsync();
        }
    }
}
