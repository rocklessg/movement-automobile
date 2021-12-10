using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace movement_auto_dtos
{
    public class VehicleQueryDto
    {
        public string? AutomakeId { get; set; }
        public string? AutoModel { get; set; }
        public string SortBy { get; set; }
        public bool IsSortAscending { get; set; }
        public int Page { get; set; }
        public byte PageSkize { get; set; }
    }
}
