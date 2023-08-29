namespace HotelAPI.Models
{
    public class Hotel : AuditBase
    {
        public string Name { get; set; }
        public string? Address { get; set; }
        public string? PhoneNumber{ get; set; }
        public Room? Room { get; set; }
    }
}
