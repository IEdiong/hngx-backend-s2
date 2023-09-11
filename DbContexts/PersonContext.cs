using hngXStageTwo.Entities;
using Microsoft.EntityFrameworkCore;

namespace hngXStageTwo.DbContexts
{
	public class PersonContext : DbContext
	{
		public DbSet<User> Users { get; set; } = null!;

		public PersonContext(DbContextOptions<PersonContext> options)
			: base(options)
		{
		}

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
			modelBuilder.Entity<User>().HasData(
				new User
				{
					Id = 1,
					FirstName = "John",
					LastName = "Doe",
					Email = "john.doe@yahoo.com",
					Birthdate = new DateTime(1985,07,15),
					Address = "123 Main St, Anytown, CA",
					PhoneNumber = 2345586752,
					CreatedTime = DateTime.Now,
					UpdatedTime = DateTime.Now
				}
				);
            base.OnModelCreating(modelBuilder);
        }
    }
}

