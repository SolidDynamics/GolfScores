using System;
using System.Collections.Generic;
using System.Reflection.Metadata;
using System.Text;

namespace GolfScores.CLI.Model
{
	public class RoundSource
	{
		public int ID { get; set; }
		public string SourceName { get; set; }
		public byte[] Content { get; set; }
		public string ContentType { get; set; }
	}
}
