using System;
using System.ComponentModel.DataAnnotations;

namespace EventEaseApp.Models
{
	public class Event
	{
		public int Id { get; set; }

		[Required]
		[StringLength(100)]
		public string Name { get; set; } = string.Empty;

		[Required]
		public DateTime Date { get; set; }

		[Required]
		[StringLength(200)]
		public string Location { get; set; } = string.Empty;

		public string? Description { get; set; }
	}
}

