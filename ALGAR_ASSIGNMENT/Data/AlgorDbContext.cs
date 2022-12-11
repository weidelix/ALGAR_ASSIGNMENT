using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using System.Data.Common;

namespace ALGAR_ASSIGNMENT.Data
{
	public class AlgorDBContext : DbContext
	{
		public AlgorDBContext() { }
		public AlgorDBContext(DbContextOptions options) : base(options) { }

		public virtual DbSet<Contact> Contacts { get; set; }
	}
}
