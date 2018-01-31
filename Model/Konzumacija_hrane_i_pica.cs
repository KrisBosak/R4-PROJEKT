using System;

namespace R4_Projekt
{

	public class Konzumacija_hrane_i_pica : Stavka
	{
		private string ime_hrane_ili_pica;
		/*public enum tip_hrane_ili_pica { //ZA BUDUĆNOST MOŽDA
			Fastfood, Domaće, Kupovno, Alkoholno, Bezalkoholno, Gazirano
		};*/
		private string tip;
		private float energetska_vrijednost_hrane_ili_pica;

		public Konzumacija_hrane_i_pica(string ime_hrane_ili_pica, string tip, float energetska_vrijednost_hrane_ili_pica)
		{
			this.Ime_hrane_ili_pica = ime_hrane_ili_pica;
			this.Tip = tip;
			this.Energetska_vrijednost_hrane_ili_pica = energetska_vrijednost_hrane_ili_pica;
		}

		public string Ime_hrane_ili_pica
		{
			get
			{
				return ime_hrane_ili_pica;
			}
			set
			{
				ime_hrane_ili_pica = value;
			}
		}
		public float Energetska_vrijednost_hrane_ili_pica
		{
			get
			{
				return energetska_vrijednost_hrane_ili_pica;
			}
			set
			{
				energetska_vrijednost_hrane_ili_pica = value;
			}
		}
		public string Tip
		{
			get
			{
				return tip;
			}
			set
			{
				tip = value;
			}
		}
	}
}
