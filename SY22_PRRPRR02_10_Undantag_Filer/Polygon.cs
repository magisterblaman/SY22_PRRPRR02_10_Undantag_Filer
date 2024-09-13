using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SY22_PRRPRR02_10_Undantag_Filer {
	internal class Polygon {
		private string _fillColor;
		private string _borderColor;
		private Coordinate[] _corners;

		public string FillColor {
			get {
				return _fillColor;
			}
			set {
				_fillColor = value;
			}
		}

		public string BorderColor {
			get {
				return _borderColor;
			}
			set {
				_borderColor = value;
			}
		}

		public Coordinate[] Corners {
			get {
				return _corners;
			}
			set {
				_corners = value;
			}
		}
	}
}
