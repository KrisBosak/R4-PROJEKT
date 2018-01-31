using System;

namespace R4_Projekt
{

	public class Korisnik
	{
		private string ime;
		private string prezime;
		private string nadimak;
		private string lozinka;
		private string email;
		private float godine;
		private float visina;
		private float tezina;
		private float bmi;
		private bool admin;

		public Korisnik()
		{
		}
		public string Ime
		{
			get
			{
				return ime;
			}
			set
			{
				ime = value;
			}
		}

		public string Prezime
		{
			get
			{
				return prezime;
			}
			set
			{
				prezime = value;
			}

		}

		public string Nadimak{
			get{
				return nadimak;
			}
			set{
				nadimak = value;
			}
		}

		public string Lozinka{
			get{
				return lozinka;
			}
			set{
				lozinka = value;
			}
		}

		public string Email { 
			get {
				return email;
			}
			set {
				email = value;
			}
		}

		public float Godine{
			get{
				return godine;
			}
			set{
				godine = value;
			}
		}

		public float Visina{
			get{
				return visina;
			}
			set{
				visina = value;
			}
		}

		public float Tezina{
			get{
				return tezina;
			}
			set{
				tezina = value;
			}
		}

		public float Bmi{
			get{
				return bmi;
			}
			set{
				bmi = value;
			}
		}

		public bool Admin{
			get{
				return admin;
			}
			set{
				admin = value;
			}
		}
	}
}
