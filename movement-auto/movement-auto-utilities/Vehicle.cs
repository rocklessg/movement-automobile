using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace movement_auto_models
{
    [Table("Vehicle")]
    public class Vehicle
    {
        public string Id { get; set; }
        public string AutoModelId { get; set; }
        public AutoModel AutoModel { get; set; }
        public bool IsRegistered { get; set; }
        
        [Required]
        [StringLength(255)]
        public string ContactName { get; set; }
        
        [StringLength(255)]
        public string ContactEmail { get; set; }

        [Required]
        [StringLength(255)]
        public string ContactPhone { get; set; }
        public string Color { get; set; }
        public string Maliage { get; set; }
        public decimal Price { get; set; }
        public decimal Discount { get; set; }
        public DateTime UpdatetdAt { get; set; }
        public ICollection<Image> Images { get; set; }
        public ICollection<VehicleFeature> VehicleFeatures { get; set; }

        public Vehicle()
        {
            VehicleFeatures = new Collection<VehicleFeature>();
            Images = new Collection<Image>();
        }

    }
}