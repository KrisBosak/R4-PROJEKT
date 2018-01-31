using System;

namespace R4_Projekt
{
	public partial class PocetnaWindow : Gtk.Window
	{
		public PocetnaWindow() :
				base(Gtk.WindowType.Toplevel)
		{
			this.Build();
		}

		protected void Ulaz(object sender, EventArgs e)
		{
			UlazWindow win = new UlazWindow();
			win.Show();
			this.Destroyed -= Ulaz;
			this.Destroy();
		}

		protected void Profil(object sender, EventArgs e)
		{
			ProfilWindow win = new ProfilWindow();
			win.Show();
			this.Destroyed -= Profil;
			this.Destroy();
		}

		protected void Dokumentacija(object sender, EventArgs e)
		{
			DokumentacijaWindow win = new DokumentacijaWindow();
			win.Show();
			this.Destroyed -= Dokumentacija;
			this.Destroy();
		}

		protected void Izlaz(object sender, EventArgs e)
		{
			this.Destroyed -= Izlaz;
			this.Destroy();
		}
	}
}
