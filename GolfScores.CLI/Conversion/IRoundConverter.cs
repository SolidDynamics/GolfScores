using GolfScores.CLI.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace GolfScores.CLI.Conversion
{
	interface IRoundConverter
	{
		public Round GetRoundFromSource(RoundSource roundSource);
	}
}
