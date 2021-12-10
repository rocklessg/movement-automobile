using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;

namespace movement_auto_dtos
{
    public class SaveVehicleDto
    {
        public string Id { get; set; }
        public string AutoModelId { get; set; }
        public bool IsRegistered { get; set; }

        [Required]
        public ContactDto Contact { get; set; }
        public ICollection<string> Features { get; set; }

        public SaveVehicleDto()
        {
            Features = new Collection<string>();   
        }
    }
}
