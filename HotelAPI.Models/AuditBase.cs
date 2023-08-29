using System.ComponentModel.DataAnnotations;

namespace HotelAPI.Models
{
    public class AuditBase
    {
        [Key]
        public Guid Id { get; set; }
        public DateTime? InsertedDate { get; set; }
        public DateTime? UpdatedDate { get; set; }
    }
}