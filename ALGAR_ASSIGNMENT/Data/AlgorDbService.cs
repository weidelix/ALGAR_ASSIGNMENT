using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Internal;

namespace ALGAR_ASSIGNMENT.Data
{
	public class AlgorDbService
	{
		private readonly IDbContextFactory<AlgorDbContext> _contextFactory;

		public AlgorDbService(IDbContextFactory<AlgorDbContext> _contextFactory) => this._contextFactory = _contextFactory;

		public async Task<List<Contact>> GetAllContactsAsync()
		{
			List<Contact> result = new List<Contact>();
			using (var context = _contextFactory.CreateDbContext())
			{
				result = await context.Contacts.ToListAsync();
			}

			return result;
		}

		public List<Contact> GetContact(string firstName)
		{
			List<Contact> result;

			using (var context = _contextFactory.CreateDbContext())
			{
				result = context.Contacts.Where(e => e.FirstName.ToLower().Contains(firstName)).ToList();
			}

			return result;
		}

		public void DeleteContact(Contact contact)
		{
			using (var context = _contextFactory.CreateDbContext())
			{
				context.Contacts.Remove(contact);
				context.SaveChanges();
			}
		}

		public void AddContact(Contact contact)
		{
			using (var context = _contextFactory.CreateDbContext())
			{
				context.Contacts.Add(contact);
				context.SaveChanges();
			}
		}

		public void UpdateContact(Contact contact)
		{
			using (var context = _contextFactory.CreateDbContext())
			{
				context.Entry(contact).State = EntityState.Modified;
				context.SaveChanges();
			}
		}
	}
}
