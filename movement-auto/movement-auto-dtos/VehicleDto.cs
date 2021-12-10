using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace movement_auto_dtos
{
    public class VehicleDto
    {
        public string Id { get; set; }
        public KeyValuePairDto AutoModel { get; set; }
        public KeyValuePairDto AutoMake { get; set; }
        public bool IsRegistered { get; set; }
        public ContactDto Contact { get; set; }
        public DateTime UpdatedAt { get; set; }
        public ICollection<KeyValuePairDto> Features { get; set; }

        public VehicleDto()
        {
            Features = new Collection<KeyValuePairDto>();
        }
    }
}
