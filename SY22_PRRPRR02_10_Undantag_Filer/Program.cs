using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Text.Json;

namespace SY22_PRRPRR02_10_Undantag_Filer {
	internal class Program {
		static void Main(string[] args) {

			string serialized = File.ReadAllText("polygon.json");
			Polygon deserialized = JsonSerializer.Deserialize<Polygon>(serialized);

			

		}
	}
}
