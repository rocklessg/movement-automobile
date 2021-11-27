using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace movement_auto_models
{
    public class AutoMake
    {
        
        public string Id { get; set; }

        [Required]
        [StringLength(255)]
        public string Name { get; set; }
        public ICollection<AutoModel> AutoModels { get; set; }

        public AutoMake()
        {
            AutoModels = new Collection<AutoModel>();
        }
    }
}
