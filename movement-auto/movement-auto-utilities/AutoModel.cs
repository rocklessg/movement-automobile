using System.ComponentModel.DataAnnotations;

namespace movement_auto_models
{
    public class AutoModel
    {
        public string Id { get; set; }

        [Required]
        [StringLength(255)]
        public string Name { get; set; }
        public string AutoMakeId { get; set; }
        public AutoMake AutoMake { get; set; }
        public string Year { get; set; }
    }
}