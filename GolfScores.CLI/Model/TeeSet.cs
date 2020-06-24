using Microsoft.EntityFrameworkCore.ChangeTracking;
using System.ComponentModel.DataAnnotations.Schema;

namespace GolfScores.CLI.Model
{
	public class TeeSet
	{
		public int CourseID { get; set; }
		public string Name { get; set; }

		public string Colour { get; set; }

		public int TotalYards { get; set; }

		public int HoleCount { get; set; }

		public int TotalPar { get; set; }
		public virtual Course Course { get; internal set; }
	}
}