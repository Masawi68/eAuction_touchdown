﻿using eAuction_touchdown.Models;
using Microsoft.EntityFrameworkCore;

namespace eAuction_touchdown.Data
{
	public class AppDbContext:DbContext
	{
		public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
		{

		}

		protected override void OnModelCreating(ModelBuilder modelBuilder)
		{
			base.OnModelCreating(modelBuilder);
		}
		

		public DbSet<Vehicle> Vehicles { get; set; }

	}
}
