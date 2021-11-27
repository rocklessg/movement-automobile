using System;
using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace movement_auto_models
{
    public class Feature
    {
        [Required]
        [StringLength(255)]
        public string Id { get; set; }
        public string Name { get; set; }
    }
}
