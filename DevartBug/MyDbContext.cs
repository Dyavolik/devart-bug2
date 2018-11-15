using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Logging.Console;

namespace DevartBug
{
	public class MyDbContext : DbContext
	{
		protected readonly string ConnectionString;

		public MyDbContext(string connectionString)
		{
			ConnectionString = connectionString;
		}

		protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
		{
			optionsBuilder.UseMySql(ConnectionString);
			optionsBuilder.UseLoggerFactory(new LoggerFactory(new[]
				{new ConsoleLoggerProvider((_, __) => true, true)}));
		}

		protected override void OnModelCreating(ModelBuilder modelBuilder)
		{
			modelBuilder.Entity<RecordOne>();
			modelBuilder.Entity<RecordMany>();
		}
	}
}
