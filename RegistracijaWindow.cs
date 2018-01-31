using System;
using Mono.Data.Sqlite;

namespace R4_Projekt
{
	public partial class RegistracijaWindow : Gtk.Window
	{
		public RegistracijaWindow() :
				base(Gtk.WindowType.Toplevel)
		{
            this.Build();
			RegButton.Clicked += Registracija;
		}


		protected void Registracija(object sender, EventArgs e)
		{
			BPcon.OpenConnection();

			BPkorisnik.korisnikT();

			Korisnik k = new Korisnik();
			k.Ime = entry1.Text;
			k.Prezime = entry8.Text;
			k.Nadimak = entry3.Text;
			k.Lozinka = entry4.Text;
			k.Email = entry5.Text;

			SqliteCommand com = BPcon.con.CreateCommand();

			com.CommandText = String.Format(@"INSERT INTO korisnik (ime, prezime, nadimak, lozinka, email) 
														VALUES ('{0}','{1}','{2}','{3}','{4}')",
			                                k.Ime, k.Prezime, k.Nadimak, k.Lozinka, k.Email);

			com.ExecuteNonQuery();
			com.Dispose();

			BPcon.CloseConnection();

			PrijavaWindow win = new PrijavaWindow();
			win.Show();
			this.Destroyed -= Registracija;
			this.Destroy();
		}

		protected void Vratise(object sender, EventArgs e)
		{
			PrijavaWindow win = new PrijavaWindow();
			win.Show();
			this.Destroyed -= Vratise;
			this.Destroy();
		}
	}
}
