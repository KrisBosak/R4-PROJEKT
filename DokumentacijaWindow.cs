using System;
namespace R4_Projekt
{
	public partial class DokumentacijaWindow : Gtk.Window
	{
		public DokumentacijaWindow() :
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
	}
}
