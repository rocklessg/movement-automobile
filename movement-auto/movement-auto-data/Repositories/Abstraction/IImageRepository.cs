using movement_auto_models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace movement_auto_data.Repositories.Abstraction
{
    public interface IImageRepository
    {
        Task<IEnumerable<Image>> GetImages(string vehicleId);
    }
}
