using System;
namespace R4_Projekt//ZA BUDUĆNOST MOŽDA
{
	public partial class Stat_podaciWindow : Gtk.Window
	{
		public Stat_podaciWindow() :
				base(Gtk.WindowType.Toplevel)
		{
			this.Build();

		}

		protected void Pocetna(object sender, EventArgs e)
		{
			PocetnaWindow win = new PocetnaWindow();
			win.Show();
			this.Destroyed -= Pocetna;
			this.Destroy();
		}

		protected void Nazad(object sender, EventArgs e)
		{
			ProfilWindow win = new ProfilWindow();
			win.Show();
			this.Destroyed -= Nazad;
			this.Destroy();
		}
	}
}
