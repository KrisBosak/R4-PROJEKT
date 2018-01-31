using System;

namespace R4_Projekt{ //ZA BUDUĆNOST MOŽDA
	
	public class Kalorije_po_danu : Stavka{
		private DateTime datum;
		private float zbroj;
		private string tip;
		private string vrsta;

		public Kalorije_po_danu(){
		}
		public DateTime Datum { 
			get {
				return datum;
			}
			set {
				datum = value;
			}
		}
		public float Zbroj { 
			get {
				return zbroj;
			}
			set {
				zbroj = value;
			}
		}
		public string Tip { 
			get {
				return tip;
			}
			set {
				tip = value;
			}
		}
		public string Vrsta { 
			get {
				return vrsta;
			}
			set {
				vrsta = value;

			}
		}
	}
}
