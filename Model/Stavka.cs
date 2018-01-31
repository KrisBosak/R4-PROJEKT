using System;


namespace R4_Projekt{//ZA BUDUĆNOST MOŽDA
	
	public class Stavka : Konzumacija{
		private float kolicina_hrane;
		private float kolicina_pica;
		public enum mjerna_jedinica{
			l, dl, mll, g, dag, kg
		};

		public Stavka(){
		}
		public float Kolicina_hrane { 
			get {
				return kolicina_hrane;
			}
			set {
				kolicina_hrane = value;
			}
		}
		public float Kolicina_pica { 
			get {
				return kolicina_pica;
			}
			set {
				kolicina_pica = value;
			}
		}
	}
}
