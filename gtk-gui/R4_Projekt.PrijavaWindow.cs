
// This file has been generated by the GUI designer. Do not modify.
namespace R4_Projekt
{
	public partial class PrijavaWindow
	{
		private global::Gtk.VBox vbox1;

		private global::Gtk.HBox hbox1;

		private global::Gtk.Label Kor_imeLabel;

		private global::Gtk.Entry Kor_imeEntry;

		private global::Gtk.HBox hbox2;

		private global::Gtk.Label LozLabel;

		private global::Gtk.Entry LozEntry;

		private global::Gtk.HBox hbox3;

		private global::Gtk.HBox hbox6;

		private global::Gtk.Button PrijavaButton;

		private global::Gtk.Button RegistracijaButton;

		protected virtual void Build()
		{
			global::Stetic.Gui.Initialize(this);
			// Widget R4_Projekt.PrijavaWindow
			this.Name = "R4_Projekt.PrijavaWindow";
			this.Title = global::Mono.Unix.Catalog.GetString("Prijava");
			this.WindowPosition = ((global::Gtk.WindowPosition)(3));
			this.Modal = true;
			this.BorderWidth = ((uint)(23));
			this.AllowGrow = false;
			// Container child R4_Projekt.PrijavaWindow.Gtk.Container+ContainerChild
			this.vbox1 = new global::Gtk.VBox();
			this.vbox1.Name = "vbox1";
			this.vbox1.Homogeneous = true;
			this.vbox1.Spacing = 15;
			// Container child vbox1.Gtk.Box+BoxChild
			this.hbox1 = new global::Gtk.HBox();
			this.hbox1.Name = "hbox1";
			this.hbox1.Spacing = 6;
			// Container child hbox1.Gtk.Box+BoxChild
			this.Kor_imeLabel = new global::Gtk.Label();
			this.Kor_imeLabel.WidthRequest = 100;
			this.Kor_imeLabel.Name = "Kor_imeLabel";
			this.Kor_imeLabel.Xpad = 2;
			this.Kor_imeLabel.LabelProp = global::Mono.Unix.Catalog.GetString("Korisničko ime:");
			this.hbox1.Add(this.Kor_imeLabel);
			global::Gtk.Box.BoxChild w1 = ((global::Gtk.Box.BoxChild)(this.hbox1[this.Kor_imeLabel]));
			w1.Position = 0;
			w1.Fill = false;
			// Container child hbox1.Gtk.Box+BoxChild
			this.Kor_imeEntry = new global::Gtk.Entry();
			this.Kor_imeEntry.WidthRequest = 350;
			this.Kor_imeEntry.CanFocus = true;
			this.Kor_imeEntry.Name = "Kor_imeEntry";
			this.Kor_imeEntry.IsEditable = true;
			this.Kor_imeEntry.InvisibleChar = '●';
			this.hbox1.Add(this.Kor_imeEntry);
			global::Gtk.Box.BoxChild w2 = ((global::Gtk.Box.BoxChild)(this.hbox1[this.Kor_imeEntry]));
			w2.Position = 1;
			w2.Expand = false;
			w2.Fill = false;
			this.vbox1.Add(this.hbox1);
			global::Gtk.Box.BoxChild w3 = ((global::Gtk.Box.BoxChild)(this.vbox1[this.hbox1]));
			w3.Position = 0;
			w3.Expand = false;
			w3.Fill = false;
			// Container child vbox1.Gtk.Box+BoxChild
			this.hbox2 = new global::Gtk.HBox();
			this.hbox2.Name = "hbox2";
			this.hbox2.Spacing = 6;
			// Container child hbox2.Gtk.Box+BoxChild
			this.LozLabel = new global::Gtk.Label();
			this.LozLabel.WidthRequest = 100;
			this.LozLabel.Name = "LozLabel";
			this.LozLabel.LabelProp = global::Mono.Unix.Catalog.GetString("Lozinka:");
			this.hbox2.Add(this.LozLabel);
			global::Gtk.Box.BoxChild w4 = ((global::Gtk.Box.BoxChild)(this.hbox2[this.LozLabel]));
			w4.Position = 0;
			w4.Fill = false;
			// Container child hbox2.Gtk.Box+BoxChild
			this.LozEntry = new global::Gtk.Entry();
			this.LozEntry.WidthRequest = 350;
			this.LozEntry.CanFocus = true;
			this.LozEntry.Name = "LozEntry";
			this.LozEntry.IsEditable = true;
			this.LozEntry.Visibility = false;
			this.LozEntry.InvisibleChar = '●';
			this.hbox2.Add(this.LozEntry);
			global::Gtk.Box.BoxChild w5 = ((global::Gtk.Box.BoxChild)(this.hbox2[this.LozEntry]));
			w5.Position = 1;
			w5.Expand = false;
			w5.Fill = false;
			this.vbox1.Add(this.hbox2);
			global::Gtk.Box.BoxChild w6 = ((global::Gtk.Box.BoxChild)(this.vbox1[this.hbox2]));
			w6.Position = 1;
			w6.Expand = false;
			w6.Fill = false;
			// Container child vbox1.Gtk.Box+BoxChild
			this.hbox3 = new global::Gtk.HBox();
			this.hbox3.WidthRequest = 50;
			this.hbox3.HeightRequest = 50;
			this.hbox3.Name = "hbox3";
			this.hbox3.Spacing = 6;
			// Container child hbox3.Gtk.Box+BoxChild
			this.hbox6 = new global::Gtk.HBox();
			this.hbox6.Name = "hbox6";
			this.hbox6.Spacing = 6;
			// Container child hbox6.Gtk.Box+BoxChild
			this.PrijavaButton = new global::Gtk.Button();
			this.PrijavaButton.WidthRequest = 100;
			this.PrijavaButton.HeightRequest = 50;
			this.PrijavaButton.CanFocus = true;
			this.PrijavaButton.Name = "PrijavaButton";
			this.PrijavaButton.UseUnderline = true;
			this.PrijavaButton.Label = global::Mono.Unix.Catalog.GetString("Prijava");
			global::Gtk.Image w7 = new global::Gtk.Image();
			w7.Pixbuf = global::Stetic.IconLoader.LoadIcon(this, "gtk-apply", global::Gtk.IconSize.Menu);
			this.PrijavaButton.Image = w7;
			this.hbox6.Add(this.PrijavaButton);
			global::Gtk.Box.BoxChild w8 = ((global::Gtk.Box.BoxChild)(this.hbox6[this.PrijavaButton]));
			w8.Position = 0;
			w8.Expand = false;
			w8.Padding = ((uint)(78));
			// Container child hbox6.Gtk.Box+BoxChild
			this.RegistracijaButton = new global::Gtk.Button();
			this.RegistracijaButton.WidthRequest = 100;
			this.RegistracijaButton.HeightRequest = 50;
			this.RegistracijaButton.CanFocus = true;
			this.RegistracijaButton.Name = "RegistracijaButton";
			this.RegistracijaButton.UseUnderline = true;
			this.RegistracijaButton.Label = global::Mono.Unix.Catalog.GetString("Registracija");
			global::Gtk.Image w9 = new global::Gtk.Image();
			w9.Pixbuf = global::Stetic.IconLoader.LoadIcon(this, "gtk-go-forward", global::Gtk.IconSize.Menu);
			this.RegistracijaButton.Image = w9;
			this.hbox6.Add(this.RegistracijaButton);
			global::Gtk.Box.BoxChild w10 = ((global::Gtk.Box.BoxChild)(this.hbox6[this.RegistracijaButton]));
			w10.Position = 1;
			w10.Expand = false;
			w10.Fill = false;
			this.hbox3.Add(this.hbox6);
			global::Gtk.Box.BoxChild w11 = ((global::Gtk.Box.BoxChild)(this.hbox3[this.hbox6]));
			w11.Position = 0;
			w11.Expand = false;
			w11.Fill = false;
			this.vbox1.Add(this.hbox3);
			global::Gtk.Box.BoxChild w12 = ((global::Gtk.Box.BoxChild)(this.vbox1[this.hbox3]));
			w12.Position = 2;
			w12.Expand = false;
			w12.Fill = false;
			this.Add(this.vbox1);
			if ((this.Child != null))
			{
				this.Child.ShowAll();
			}
			this.DefaultWidth = 502;
			this.DefaultHeight = 265;
			this.Show();
			this.RegistracijaButton.Clicked += new global::System.EventHandler(this.Registracija);
		}
	}
}
