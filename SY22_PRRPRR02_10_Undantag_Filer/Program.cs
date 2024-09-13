using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SY22_PRRPRR02_10_Undantag_Filer {
	internal class Program {
		static void Main(string[] args) {
			try {
				Console.WriteLine("Skriv in ett tal");
				string numInput = Console.ReadLine();
				int num = int.Parse(numInput);

				int result = 100 / num;
				Console.WriteLine("Nu ska jag dela med ditt tal utan att dubbelkolla det wooooo........");
				Console.WriteLine(result);
			} catch (FormatException e) {
				Console.WriteLine("Något gick snett i konverteringen");
			} catch (DivideByZeroException e) {
				Console.WriteLine("Du skrev in en nolla din nolla");
			}
		}
	}
}
