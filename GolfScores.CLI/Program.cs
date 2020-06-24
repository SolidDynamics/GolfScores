using GolfScores.CLI.DAL;
using GolfScores.CLI.Importer;
using NLog;
using System;

namespace GolfScores.CLI
{
	class Program
	{
		private static readonly Logger logger = LogManager.GetCurrentClassLogger();

		static void Main(string[] args)
		{
			Console.WriteLine("*************************************************");
			Console.WriteLine("**             Golf Score Tracker              **");
			Console.WriteLine("*************************************************");
			var logger = NLogBuilder.ConfigureNLog("nlog.config").GetCurrentClassLogger();

			using (var db = new GolfScoreContext())
			{
				logger.Debug("Ensuring database is created");
				db.Database.EnsureCreated();

				TextCSVImporter importer = new TextCSVImporter(@"Data\MyGolfNuts.csv", (ILogger)logger);
				importer.ImportRound(db, "MyGolfNuts");
			}
			Console.ReadLine();
		}
	}
}
