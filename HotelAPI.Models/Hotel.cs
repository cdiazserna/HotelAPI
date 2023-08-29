namespace HotelAPI.Models
{
    public class Hotel : AuditBase
    {
        public string Name { get; set; } = string.Empty;
        public string? Address { get; set; } = string.Empty;
        public string? PhoneNumber{ get; set; } = string.Empty;
        public IEnumerable<Room>? Rooms{ get; set; }
    }
}
