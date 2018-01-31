using System;
using Gtk;

namespace R4_Projekt
{
	public partial class ProfilWindow : Gtk.Window
	{
		public ProfilWindow() :
				base(Gtk.WindowType.Toplevel)
		{
			this.Build();
			BMIButton.Clicked += Bmiizracun;
		}

		protected void Pocetna(object sender, EventArgs e)
		{
			PocetnaWindow win = new PocetnaWindow();
			win.Show();
			this.Destroyed -= Pocetna;
			this.Destroy();
		}

		protected void Bmiizracun(object sender, EventArgs e)
		{
			Korisnik kor = new Korisnik();

			kor.Godine = float.Parse(GodEntry.Text);
			kor.Visina = float.Parse(VisinaEntry.Text);
			kor.Tezina = float.Parse(TezinaEntry.Text);
			float ukp = (kor.Tezina / (kor.Visina * kor.Visina));

			BMIEntry.Text = ukp.ToString();

			if (ukp <= 16) { 
				Dialog d = new Gtk.MessageDialog(this, DialogFlags.Modal, MessageType.Warning, ButtonsType.Ok,
												 "POTHRANJENI STE");
				d.Run();
				d.Destroy();
			}

			else if (ukp > 16 && ukp <= 25 ) { 
				Dialog d = new Gtk.MessageDialog(this, DialogFlags.Modal, MessageType.Info, ButtonsType.Ok,
												 "Taman! :)");
				d.Run();
				d.Destroy();
			}

			else if (ukp > 25 && ukp <=30) { 
				Dialog d = new Gtk.MessageDialog(this, DialogFlags.Modal, MessageType.Question, ButtonsType.Ok,
												 "Bucmasto! Možda bi mogli krenuti na dijetu?");
				d.Run();
				d.Destroy();
			}

			else if (ukp > 30) { 
				Dialog d = new Gtk.MessageDialog(this, DialogFlags.Modal, MessageType.Warning, ButtonsType.Ok,
												 "POD HITNO NA DIJETU");
				d.Run();
				d.Destroy();
			}
		}
	}
}
