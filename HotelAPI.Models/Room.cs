namespace HotelAPI.Models
{
    public class Room : AuditBase
    {
        public string Name { get; set; }
        public int? MaxGuests { get; set; }
        public IEnumerable<Hotel>? Hotels { get; set; }
    }
}
