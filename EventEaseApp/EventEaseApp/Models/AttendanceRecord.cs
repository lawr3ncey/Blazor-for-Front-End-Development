using System;

namespace EventEaseApp.Models
{
    public class AttendanceRecord
    {
        public Guid Id { get; set; } = Guid.NewGuid();
        public int EventId { get; set; }
        public string Name { get; set; } = string.Empty;
        public string Email { get; set; } = string.Empty;
        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
        public bool IsPresent { get; set; } = false;
        public string Status { get; set; } = "registered"; // registered | present | cancelled
    }
}
