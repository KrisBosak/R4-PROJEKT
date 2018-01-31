using System;
using Gtk;
using System.Collections.Generic;
namespace R4_Projekt
{
	[System.ComponentModel.ToolboxItem(true)]
	public partial class PrijavaWindow : Gtk.Window
	{
		public PrijavaWindow() :
				base(Gtk.WindowType.Toplevel)

		{
			this.Build();
			PrijavaButton.Clicked += Prijava;
			RegistracijaButton.Clicked += Registracija;
		}

		protected void Registracija(object sender, EventArgs e)
		{
			RegistracijaWindow win = new RegistracijaWindow();
			win.Show();
			this.Destroyed -= Registracija;
			this.Destroy();

		}

		protected void Prijava(object sender, EventArgs e)
		{

			List<Korisnik> listaKorisnika = BPkorisnik.DohvatiSveKorisnike();

			Boolean prijavaUspjesna = false;
			foreach (var i in listaKorisnika)
			{
				if (Kor_imeEntry.Text == i.Nadimak && LozEntry.Text == i.Lozinka)
				{
					prijavaUspjesna = true;
					break;
				}
			}

			BPcon.CloseConnection();

			if (prijavaUspjesna)
			{
				PocetnaWindow win = new PocetnaWindow();
				win.Show();
				this.Destroyed -= Prijava;
				this.Destroy();
			}

			else
			{
				Dialog d = new Gtk.MessageDialog(this, DialogFlags.Modal, MessageType.Warning, ButtonsType.Ok, "Neispravno korisničko ime ili lozinka!");
				d.Run();
				d.Destroy();
			}
		}
	}
}
