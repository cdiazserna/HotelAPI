namespace HotelAPI.Models
{
    public class Room : AuditBase
    {
        public string Name { get; set; } = string.Empty;
        public int? MaxGuests { get; set; } = 0;
        public Hotel? Hotel{ get; set; }
    }
}
