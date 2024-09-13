using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace SY22_PRRPRR02_10_Undantag_Filer {
	internal class Program {
		static void Main(string[] args) {
			while (true) {
				string content2 = Console.ReadLine();

				// File.WriteAllText("test.txt", content2 + "\n");
				File.AppendAllText("test.txt", content2 + "\n");
			}
		}
	}
}
