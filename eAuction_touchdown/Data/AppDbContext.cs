using eAuction_touchdown.Data.Enum;
using eAuction_touchdown.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace eAuction_touchdown.Data
{
	public class AppDbContext:IdentityDbContext<ApplicationUser>
	{
		public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
		{

		}

		protected override void OnModelCreating(ModelBuilder modelBuilder)
		{
			base.OnModelCreating(modelBuilder);
		}
		

		public DbSet<Vehicles> Vehicles { get; set; }
		public DbSet<Trucks> Trucks { get; set; }

	}
}
