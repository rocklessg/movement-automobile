using movement_auto_models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace movement_auto_data.Repositories.Abstraction
{
    public interface IVehicleRepository
    {
        Task<Vehicle> GetVehicle(string id, bool  includeRelated = true);
        void Add(Vehicle vehicle);
        void Remove(Vehicle vehicle);
        Task<QueryResult<Vehicle>> GetVehicles(VehicleQuery filterQuery);
    }
}
