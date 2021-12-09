namespace movement_auto.Extensions
{
    public class VehicleQuery : IQueryObject
    {

        public string AutoMakeId { get; set; } //nullable
        public string AutoModelId { get; set; } //nullable
        public string SortBy { get; set; }
        public bool IsSortAscending { get; set; }
        public int Page { get; set; }
        public byte PageSize { get; set; }
       
    }
}
