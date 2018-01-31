using System;

namespace R4_Projekt{//ZA BUDUĆNOST MOŽDA
	
	public class Kalorije_po_satu : Stavka{
		private float ukupan_broj_kalorija;
		private DateTime sat;
		private int ukupan_broj_unosa;

		public Kalorije_po_satu(){
		}
		public float Ukupan_broj_kalorija { 
			get {
				return ukupan_broj_kalorija;
			}
			set {
				ukupan_broj_kalorija = value;
			}
		}
		public DateTime Sat { 
			get {
				return sat;
			}
			set {
				sat = value;
			}
		}
		public int Ukupan_broj_unosa { 
			get {
				return ukupan_broj_unosa;
			}
			set {
				ukupan_broj_unosa = value;
			}
		}
	}
}
