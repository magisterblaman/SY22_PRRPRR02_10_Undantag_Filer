using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace SY22_PRRPRR02_10_Undantag_Filer {
	internal class Program {
		static void Main(string[] args) {

			FileStream fs = File.Open("streamdemo.txt", FileMode.OpenOrCreate);
			StreamReader reader = new StreamReader(fs);

			while (!reader.EndOfStream) {
				Console.WriteLine(reader.ReadLine());
			}

			reader.Close();
			fs.Close(); // motsatt ordning från när vi skapade variablerna
		}
	}
}
