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

			Polygon polygon = new Polygon();

			polygon.FillColor = "red";
			polygon.BorderColor = "black";
			polygon.Corners = new Coordinate[] {
				new Coordinate(0, 0),
				new Coordinate(0, 10),
				new Coordinate(10, 10),
				new Coordinate(10, 0),
			};

			string serialized = JsonSerializer.Serialize(polygon);

			File.WriteAllText("polygon.json", serialized);



		}
	}
}
