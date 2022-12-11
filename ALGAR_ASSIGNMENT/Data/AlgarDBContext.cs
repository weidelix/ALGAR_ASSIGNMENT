using Microsoft.EntityFrameworkCore;
using System.Data.Common;

namespace ALGAR_ASSIGNMENT.Data
{
	public class AlgarDBContext : DbContext
	{
		public AlgarDBContext() { }
		public AlgarDBContext(DbContextOptions options) : base(options) { }

		public virtual DbSet<Contact> Contacts { get; set; }
	}
}
