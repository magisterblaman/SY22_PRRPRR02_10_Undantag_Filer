using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SY22_PRRPRR02_10_Undantag_Filer {
	internal class Coordinate {
		private int _x;
		private int _y;

		public int X {
			get {
				return _x;
			}
			set {
				_x = value;
			}
		}

		public int Y {
			get {
				return _y;
			}
			set {
				_y = value;
			}
		}

		public Coordinate(int inputX, int inputY) {
			X = inputX;
			Y = inputY;
		}
	}
}
