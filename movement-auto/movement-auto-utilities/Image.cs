using System;
using System.ComponentModel.DataAnnotations;

namespace movement_auto_models
{
    public class Image
    {
        public string Id { get; set; }

        [Required]
        [StringLength(255)]
        public string FileName { get; set; }
        public string VehicleId { get; set; }
    }
}
