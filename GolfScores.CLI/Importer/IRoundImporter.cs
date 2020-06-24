using GolfScores.CLI.DAL;
using GolfScores.CLI.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace GolfScores.CLI.Importer
{
	public interface IRoundImporter
	{
		public void ImportRound(GolfScoreContext db, string sourcename);
	}
}
