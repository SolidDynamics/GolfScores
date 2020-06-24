using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace GolfScores.CLI.Model
{
	public class Course
	{
		[DatabaseGenerated(DatabaseGeneratedOption.Identity)]
		public int ID { get; set; }
		public string Name { get; set; }

		public virtual ICollection<TeeSet> Tees { get; set; }
	}
}
