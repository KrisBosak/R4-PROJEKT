
// This file has been generated by the GUI designer. Do not modify.
namespace R4_Projekt
{
	public partial class RegistracijaWindow
	{
		private global::Gtk.VBox vbox1;

		private global::Gtk.HBox hbox2;

		private global::Gtk.Label ImeLabel;

		private global::Gtk.Entry entry1;

		private global::Gtk.HBox hbox3;

		private global::Gtk.Label PrezimeLabel;

		private global::Gtk.Entry entry8;

		private global::Gtk.HBox hbox4;

		private global::Gtk.Label Korisnicko_imeLabel;

		private global::Gtk.Entry entry3;

		private global::Gtk.HBox hbox5;

		private global::Gtk.Label LozinkaLabel;

		private global::Gtk.Entry entry4;

		private global::Gtk.HBox hbox6;

		private global::Gtk.Label email;

		private global::Gtk.Entry entry5;

		private global::Gtk.HBox hbox8;

		private global::Gtk.HBox hbox1;

		private global::Gtk.Button RegButton;

		private global::Gtk.Button NazadButton;

		protected virtual void Build()
		{
			global::Stetic.Gui.Initialize(this);
			// Widget R4_Projekt.RegistracijaWindow
			this.Name = "R4_Projekt.RegistracijaWindow";
			this.Title = global::Mono.Unix.Catalog.GetString("Registracija");
			this.WindowPosition = ((global::Gtk.WindowPosition)(3));
			this.BorderWidth = ((uint)(19));
			// Container child R4_Projekt.RegistracijaWindow.Gtk.Container+ContainerChild
			this.vbox1 = new global::Gtk.VBox();
			this.vbox1.Name = "vbox1";
			this.vbox1.Spacing = 6;
			// Container child vbox1.Gtk.Box+BoxChild
			this.hbox2 = new global::Gtk.HBox();
			this.hbox2.Name = "hbox2";
			this.hbox2.Spacing = 6;
			// Container child hbox2.Gtk.Box+BoxChild
			this.ImeLabel = new global::Gtk.Label();
			this.ImeLabel.WidthRequest = 100;
			this.ImeLabel.Name = "ImeLabel";
			this.ImeLabel.LabelProp = global::Mono.Unix.Catalog.GetString("Ime:");
			this.hbox2.Add(this.ImeLabel);
			global::Gtk.Box.BoxChild w1 = ((global::Gtk.Box.BoxChild)(this.hbox2[this.ImeLabel]));
			w1.Position = 0;
			w1.Expand = false;
			w1.Fill = false;
			// Container child hbox2.Gtk.Box+BoxChild
			this.entry1 = new global::Gtk.Entry();
			this.entry1.CanFocus = true;
			this.entry1.Name = "entry1";
			this.entry1.IsEditable = true;
			this.entry1.InvisibleChar = '●';
			this.hbox2.Add(this.entry1);
			global::Gtk.Box.BoxChild w2 = ((global::Gtk.Box.BoxChild)(this.hbox2[this.entry1]));
			w2.Position = 1;
			this.vbox1.Add(this.hbox2);
			global::Gtk.Box.BoxChild w3 = ((global::Gtk.Box.BoxChild)(this.vbox1[this.hbox2]));
			w3.Position = 0;
			w3.Expand = false;
			w3.Fill = false;
			// Container child vbox1.Gtk.Box+BoxChild
			this.hbox3 = new global::Gtk.HBox();
			this.hbox3.Name = "hbox3";
			this.hbox3.Spacing = 6;
			// Container child hbox3.Gtk.Box+BoxChild
			this.PrezimeLabel = new global::Gtk.Label();
			this.PrezimeLabel.WidthRequest = 100;
			this.PrezimeLabel.Name = "PrezimeLabel";
			this.PrezimeLabel.LabelProp = global::Mono.Unix.Catalog.GetString("Prezime:");
			this.hbox3.Add(this.PrezimeLabel);
			global::Gtk.Box.BoxChild w4 = ((global::Gtk.Box.BoxChild)(this.hbox3[this.PrezimeLabel]));
			w4.Position = 0;
			w4.Expand = false;
			w4.Fill = false;
			// Container child hbox3.Gtk.Box+BoxChild
			this.entry8 = new global::Gtk.Entry();
			this.entry8.CanFocus = true;
			this.entry8.Name = "entry8";
			this.entry8.IsEditable = true;
			this.entry8.InvisibleChar = '●';
			this.hbox3.Add(this.entry8);
			global::Gtk.Box.BoxChild w5 = ((global::Gtk.Box.BoxChild)(this.hbox3[this.entry8]));
			w5.Position = 1;
			this.vbox1.Add(this.hbox3);
			global::Gtk.Box.BoxChild w6 = ((global::Gtk.Box.BoxChild)(this.vbox1[this.hbox3]));
			w6.Position = 1;
			w6.Expand = false;
			w6.Fill = false;
			// Container child vbox1.Gtk.Box+BoxChild
			this.hbox4 = new global::Gtk.HBox();
			this.hbox4.Name = "hbox4";
			this.hbox4.Spacing = 6;
			// Container child hbox4.Gtk.Box+BoxChild
			this.Korisnicko_imeLabel = new global::Gtk.Label();
			this.Korisnicko_imeLabel.WidthRequest = 100;
			this.Korisnicko_imeLabel.Name = "Korisnicko_imeLabel";
			this.Korisnicko_imeLabel.LabelProp = global::Mono.Unix.Catalog.GetString("Korisničko ime:");
			this.hbox4.Add(this.Korisnicko_imeLabel);
			global::Gtk.Box.BoxChild w7 = ((global::Gtk.Box.BoxChild)(this.hbox4[this.Korisnicko_imeLabel]));
			w7.Position = 0;
			w7.Expand = false;
			w7.Fill = false;
			// Container child hbox4.Gtk.Box+BoxChild
			this.entry3 = new global::Gtk.Entry();
			this.entry3.CanFocus = true;
			this.entry3.Name = "entry3";
			this.entry3.IsEditable = true;
			this.entry3.InvisibleChar = '●';
			this.hbox4.Add(this.entry3);
			global::Gtk.Box.BoxChild w8 = ((global::Gtk.Box.BoxChild)(this.hbox4[this.entry3]));
			w8.Position = 1;
			this.vbox1.Add(this.hbox4);
			global::Gtk.Box.BoxChild w9 = ((global::Gtk.Box.BoxChild)(this.vbox1[this.hbox4]));
			w9.Position = 2;
			w9.Expand = false;
			w9.Fill = false;
			// Container child vbox1.Gtk.Box+BoxChild
			this.hbox5 = new global::Gtk.HBox();
			this.hbox5.Name = "hbox5";
			this.hbox5.Spacing = 6;
			// Container child hbox5.Gtk.Box+BoxChild
			this.LozinkaLabel = new global::Gtk.Label();
			this.LozinkaLabel.WidthRequest = 100;
			this.LozinkaLabel.Name = "LozinkaLabel";
			this.LozinkaLabel.LabelProp = global::Mono.Unix.Catalog.GetString("Lozinka:");
			this.hbox5.Add(this.LozinkaLabel);
			global::Gtk.Box.BoxChild w10 = ((global::Gtk.Box.BoxChild)(this.hbox5[this.LozinkaLabel]));
			w10.Position = 0;
			w10.Expand = false;
			w10.Fill = false;
			// Container child hbox5.Gtk.Box+BoxChild
			this.entry4 = new global::Gtk.Entry();
			this.entry4.CanFocus = true;
			this.entry4.Name = "entry4";
			this.entry4.IsEditable = true;
			this.entry4.Visibility = false;
			this.entry4.InvisibleChar = '●';
			this.hbox5.Add(this.entry4);
			global::Gtk.Box.BoxChild w11 = ((global::Gtk.Box.BoxChild)(this.hbox5[this.entry4]));
			w11.Position = 1;
			this.vbox1.Add(this.hbox5);
			global::Gtk.Box.BoxChild w12 = ((global::Gtk.Box.BoxChild)(this.vbox1[this.hbox5]));
			w12.Position = 3;
			w12.Expand = false;
			w12.Fill = false;
			// Container child vbox1.Gtk.Box+BoxChild
			this.hbox6 = new global::Gtk.HBox();
			this.hbox6.Name = "hbox6";
			this.hbox6.Spacing = 6;
			// Container child hbox6.Gtk.Box+BoxChild
			this.email = new global::Gtk.Label();
			this.email.WidthRequest = 100;
			this.email.Name = "email";
			this.email.LabelProp = global::Mono.Unix.Catalog.GetString("E-mail:");
			this.hbox6.Add(this.email);
			global::Gtk.Box.BoxChild w13 = ((global::Gtk.Box.BoxChild)(this.hbox6[this.email]));
			w13.Position = 0;
			w13.Expand = false;
			w13.Fill = false;
			// Container child hbox6.Gtk.Box+BoxChild
			this.entry5 = new global::Gtk.Entry();
			this.entry5.CanFocus = true;
			this.entry5.Name = "entry5";
			this.entry5.IsEditable = true;
			this.entry5.InvisibleChar = '●';
			this.hbox6.Add(this.entry5);
			global::Gtk.Box.BoxChild w14 = ((global::Gtk.Box.BoxChild)(this.hbox6[this.entry5]));
			w14.Position = 1;
			this.vbox1.Add(this.hbox6);
			global::Gtk.Box.BoxChild w15 = ((global::Gtk.Box.BoxChild)(this.vbox1[this.hbox6]));
			w15.Position = 4;
			w15.Expand = false;
			w15.Fill = false;
			// Container child vbox1.Gtk.Box+BoxChild
			this.hbox8 = new global::Gtk.HBox();
			this.hbox8.Name = "hbox8";
			this.hbox8.Spacing = 6;
			this.hbox8.BorderWidth = ((uint)(41));
			// Container child hbox8.Gtk.Box+BoxChild
			this.hbox1 = new global::Gtk.HBox();
			this.hbox1.Name = "hbox1";
			this.hbox1.Spacing = 6;
			// Container child hbox1.Gtk.Box+BoxChild
			this.RegButton = new global::Gtk.Button();
			this.RegButton.CanFocus = true;
			this.RegButton.Name = "RegButton";
			this.RegButton.UseUnderline = true;
			this.RegButton.Label = global::Mono.Unix.Catalog.GetString("Registriraj se");
			this.hbox1.Add(this.RegButton);
			global::Gtk.Box.BoxChild w16 = ((global::Gtk.Box.BoxChild)(this.hbox1[this.RegButton]));
			w16.Position = 0;
			w16.Expand = false;
			w16.Fill = false;
			// Container child hbox1.Gtk.Box+BoxChild
			this.NazadButton = new global::Gtk.Button();
			this.NazadButton.CanFocus = true;
			this.NazadButton.Name = "NazadButton";
			this.NazadButton.UseUnderline = true;
			this.NazadButton.Label = global::Mono.Unix.Catalog.GetString("Nazad");
			this.hbox1.Add(this.NazadButton);
			global::Gtk.Box.BoxChild w17 = ((global::Gtk.Box.BoxChild)(this.hbox1[this.NazadButton]));
			w17.Position = 1;
			w17.Expand = false;
			w17.Fill = false;
			this.hbox8.Add(this.hbox1);
			global::Gtk.Box.BoxChild w18 = ((global::Gtk.Box.BoxChild)(this.hbox8[this.hbox1]));
			w18.Position = 0;
			w18.Expand = false;
			w18.Fill = false;
			this.vbox1.Add(this.hbox8);
			global::Gtk.Box.BoxChild w19 = ((global::Gtk.Box.BoxChild)(this.vbox1[this.hbox8]));
			w19.Position = 5;
			w19.Expand = false;
			w19.Fill = false;
			this.Add(this.vbox1);
			if ((this.Child != null))
			{
				this.Child.ShowAll();
			}
			this.DefaultWidth = 708;
			this.DefaultHeight = 382;
			this.Show();
			this.NazadButton.Clicked += new global::System.EventHandler(this.Vratise);
		}
	}
}
