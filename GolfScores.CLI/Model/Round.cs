using System;
using System.Collections.Generic;
using System.Text;

namespace GolfScores.CLI.Model
{
	public class Round
	{
		public int RoundID { get; set; }
		public int TeeSetID { get; set; }
		public DateTime RoundDate { get; set; }
		public int RoundOrder { get; set; }

		public virtual TeeSet Tees { get; set; }
	}
}
