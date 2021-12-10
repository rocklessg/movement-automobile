using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace movement_auto_dtos
{
    public class AutoMakeDto : KeyValuePairDto
    {
        public ICollection<KeyValuePairDto> Models { get; set; }

        public AutoMakeDto()
        {
            Models = new Collection<KeyValuePairDto>();
        }
    }
}
