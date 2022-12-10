using Microsoft.EntityFrameworkCore;

namespace ALGAR_ASSIGNMENT.Data
{
	public class AlgorDbContext : DbContext
	{
		public AlgorDbContext(DbContextOptions options) : base(options) { }

		public virtual DbSet<Contact> Contacts { get; set; }
	}
}
