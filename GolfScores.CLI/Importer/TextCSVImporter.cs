using GolfScores.CLI.DAL;
using GolfScores.CLI.Model;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace GolfScores.CLI.Importer
{
	
	public class TextCSVImporter : IRoundImporter
	{
		public string FileName { get; }
		public ILogger<TextCSVImporter> Log { get; }
		public string SourceName { get; }

		public TextCSVImporter(string filename, ILogger<TextCSVImporter> logger)
		{
			FileName = filename;
			Log = logger;
		}

		public void ImportRound(GolfScoreContext db, string sourcename)
		{
			var sourceAlreadyExists = db.RoundSources.Find(sourcename) != null;
			if(sourceAlreadyExists)
			{
				Log.LogInformation("Source with name {0} already exists", sourcename);
				return;
			}

			RoundSource roundSource = new RoundSource
			{
				SourceName = sourcename,
				ContentType = "text/CSV",
				Content = File.ReadAllBytes(FileName)
			};

			db.RoundSources.Add(roundSource);
			db.SaveChanges();
		}
	}
}
