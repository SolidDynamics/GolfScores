using GolfScores.CLI.Model;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace GolfScores.CLI.DAL
{
	public class GolfScoreContext : DbContext
	{

		public GolfScoreContext()
		{
		}

		public DbSet<Course> Courses { get; set; }
		public DbSet<TeeSet> TeeSets { get; set; }
		public DbSet<Round> Round { get; set; }
		public DbSet<RoundSource> RoundSources { get; set; }

		protected override void OnConfiguring(DbContextOptionsBuilder options)
		{
			options.UseSqlite("Data Source=GolfScores.db");
		}

		protected override void OnModelCreating(ModelBuilder modelBuilder)
		{
			foreach (IMutableEntityType entityType in modelBuilder.Model.GetEntityTypes())
			{
				entityType.SetTableName(entityType.DisplayName());
			}

			modelBuilder.Entity<TeeSet>()
				.HasKey(t => new { t.CourseID, t.Name });

			modelBuilder.Entity<RoundSource>()
					.HasKey(t => new { t.SourceName });
		}
	}
}