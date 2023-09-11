using hngXStageTwo.Entities;
using Microsoft.EntityFrameworkCore;

namespace hngXStageTwo.DbContexts
{
	public class PersonContext : DbContext
	{
		public DbSet<Person> People { get; set; } = null!;

		public PersonContext(DbContextOptions<PersonContext> options)
			: base(options)
		{
		}

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
			modelBuilder.Entity<Person>().HasData(
				new Person
				{
					Id = 1,
					Name = "John Doe",
					Email = "john.doe@yahoo.com",
				}
				);
            base.OnModelCreating(modelBuilder);
        }
    }
}

