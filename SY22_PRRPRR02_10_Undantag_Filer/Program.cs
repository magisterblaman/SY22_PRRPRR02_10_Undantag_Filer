using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace SY22_PRRPRR02_10_Undantag_Filer {
	internal class Program {
		static void Main(string[] args) {
			Console.WriteLine("Skriv in ett filnamn");
			string path = Console.ReadLine();

			if (File.Exists(path)) {
				string content = File.ReadAllText(path);
				Console.WriteLine(content);
			} else {
				Console.WriteLine("Kunde inte hitta filen!");
			}

		}
	}
}
