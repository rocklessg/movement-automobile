using movement_auto_models;
using System.Linq;

namespace movement_auto.Extensions
{
    public static class QueryExtentions
    {

        public static IQueryable<Vehicle> ApplyFiltering(this IQueryable<Vehicle> query, VehicleQuery vehicleQueryObject)
        {
            if (vehicleQueryObject.AutoMakeId.Any())
                query = query.Where(v => v.AutoModel.AutoMakeId == vehicleQueryObject.AutoMakeId);

            if (vehicleQueryObject.AutoModelId.Any())
                query = query.Where(v => v.AutoModelId == vehicleQueryObject.AutoModelId);

            return query;
        }
    }
}
