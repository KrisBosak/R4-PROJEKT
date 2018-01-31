using System;

namespace R4_Projekt{//ZA BUDUĆNOST MOŽDA
	
	public class Konzumacija{
		private DateTime datum_konzumacije;
		private DateTime vrijeme_konzumacije;

		public Konzumacija(){
		}
		public DateTime Datum_konzumacije {
			get {
				return datum_konzumacije;
			}
			set {
				datum_konzumacije = value;
			}
		}
		public DateTime Vrijeme_konzumacije { 
			get {
				return vrijeme_konzumacije;
			}
			set {
				vrijeme_konzumacije = value;
			}
		}
	}
}
