using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ALGAR_ASSIGNMENT.Data
{
	public class Contact
	{
		[Key]
		public int ContactId { get; set; }

		[Required]
		[StringLength(100)]
		public string FirstName { get; set; }

		[Required]
		[StringLength(100)]
		public string LastName { get; set; }

		[Required]
		[StringLength(100)]
		public string Phone { get; set; }

		[StringLength(100)]
		public string? Email { get; set; }
	}
}
