using Microsoft.EntityFrameworkCore;
using System.Data.SqlClient;
using Database.Entities;

namespace Database
{
	public class Context : DbContext
	{
		private readonly string _connectionString;

		public Context()
		{
			_connectionString = "ConnectionString";
		}
		protected override void OnModelCreating(ModelBuilder modelBuilder)
		{
			modelBuilder.HasDefaultSchema(Constants.schema);

			base.OnModelCreating(modelBuilder);
		}

		protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
		{
			optionsBuilder.UseSqlServer(_connectionString);
			base.OnConfiguring(optionsBuilder);
		}

		public DbSet<Item> Items { get; set; }
		public DbSet<OrderItem> OrderItems { get; set; }

	}

}
