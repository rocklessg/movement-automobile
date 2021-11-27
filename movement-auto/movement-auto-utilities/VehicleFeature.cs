using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace movement_auto_models
{
    [Table("VehicleFeatures")]
    public class VehicleFeature
    {
        public string Id { get; set; }
        public string VehicleId { get; set; }
        public string FeatureId  { get; set; }
    }
}
