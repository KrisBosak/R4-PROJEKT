
// This file has been generated by the GUI designer. Do not modify.
namespace R4_Projekt
{
	public partial class ProfilWindow
	{
		private global::Gtk.VBox vbox1;

		private global::Gtk.HBox hbox2;

		private global::Gtk.Label GodineLabel;

		private global::Gtk.Entry GodEntry;

		private global::Gtk.HBox hbox3;

		private global::Gtk.Label TezinaLabel;

		private global::Gtk.Entry TezinaEntry;

		private global::Gtk.HBox hbox4;

		private global::Gtk.Label VisinaLabel;

		private global::Gtk.Entry VisinaEntry;

		private global::Gtk.HBox hbox5;

		private global::Gtk.Label bmiLabel;

		private global::Gtk.Entry BMIEntry;

		private global::Gtk.HBox hbox6;

		private global::Gtk.Button PocetnaButton;

		private global::Gtk.Button BMIButton;

		protected virtual void Build()
		{
			global::Stetic.Gui.Initialize(this);
			// Widget R4_Projekt.ProfilWindow
			this.Name = "R4_Projekt.ProfilWindow";
			this.Title = global::Mono.Unix.Catalog.GetString("Profil");
			this.WindowPosition = ((global::Gtk.WindowPosition)(3));
			this.BorderWidth = ((uint)(13));
			// Container child R4_Projekt.ProfilWindow.Gtk.Container+ContainerChild
			this.vbox1 = new global::Gtk.VBox();
			this.vbox1.Name = "vbox1";
			this.vbox1.Spacing = 6;
			// Container child vbox1.Gtk.Box+BoxChild
			this.hbox2 = new global::Gtk.HBox();
			this.hbox2.Name = "hbox2";
			this.hbox2.Spacing = 6;
			this.hbox2.BorderWidth = ((uint)(5));
			// Container child hbox2.Gtk.Box+BoxChild
			this.GodineLabel = new global::Gtk.Label();
			this.GodineLabel.WidthRequest = 100;
			this.GodineLabel.Name = "GodineLabel";
			this.GodineLabel.LabelProp = global::Mono.Unix.Catalog.GetString("Godine:");
			this.hbox2.Add(this.GodineLabel);
			global::Gtk.Box.BoxChild w1 = ((global::Gtk.Box.BoxChild)(this.hbox2[this.GodineLabel]));
			w1.Position = 0;
			w1.Expand = false;
			w1.Fill = false;
			// Container child hbox2.Gtk.Box+BoxChild
			this.GodEntry = new global::Gtk.Entry();
			this.GodEntry.CanFocus = true;
			this.GodEntry.Name = "GodEntry";
			this.GodEntry.IsEditable = true;
			this.GodEntry.InvisibleChar = '●';
			this.hbox2.Add(this.GodEntry);
			global::Gtk.Box.BoxChild w2 = ((global::Gtk.Box.BoxChild)(this.hbox2[this.GodEntry]));
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
			this.hbox3.BorderWidth = ((uint)(5));
			// Container child hbox3.Gtk.Box+BoxChild
			this.TezinaLabel = new global::Gtk.Label();
			this.TezinaLabel.WidthRequest = 100;
			this.TezinaLabel.Name = "TezinaLabel";
			this.TezinaLabel.LabelProp = global::Mono.Unix.Catalog.GetString("Težina:");
			this.hbox3.Add(this.TezinaLabel);
			global::Gtk.Box.BoxChild w4 = ((global::Gtk.Box.BoxChild)(this.hbox3[this.TezinaLabel]));
			w4.Position = 0;
			w4.Expand = false;
			w4.Fill = false;
			// Container child hbox3.Gtk.Box+BoxChild
			this.TezinaEntry = new global::Gtk.Entry();
			this.TezinaEntry.CanFocus = true;
			this.TezinaEntry.Name = "TezinaEntry";
			this.TezinaEntry.IsEditable = true;
			this.TezinaEntry.InvisibleChar = '●';
			this.hbox3.Add(this.TezinaEntry);
			global::Gtk.Box.BoxChild w5 = ((global::Gtk.Box.BoxChild)(this.hbox3[this.TezinaEntry]));
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
			this.hbox4.BorderWidth = ((uint)(5));
			// Container child hbox4.Gtk.Box+BoxChild
			this.VisinaLabel = new global::Gtk.Label();
			this.VisinaLabel.WidthRequest = 100;
			this.VisinaLabel.Name = "VisinaLabel";
			this.VisinaLabel.LabelProp = global::Mono.Unix.Catalog.GetString("Visina:");
			this.hbox4.Add(this.VisinaLabel);
			global::Gtk.Box.BoxChild w7 = ((global::Gtk.Box.BoxChild)(this.hbox4[this.VisinaLabel]));
			w7.Position = 0;
			w7.Expand = false;
			w7.Fill = false;
			// Container child hbox4.Gtk.Box+BoxChild
			this.VisinaEntry = new global::Gtk.Entry();
			this.VisinaEntry.CanFocus = true;
			this.VisinaEntry.Events = ((global::Gdk.EventMask)(258));
			this.VisinaEntry.Name = "VisinaEntry";
			this.VisinaEntry.Text = global::Mono.Unix.Catalog.GetString("0,00");
			this.VisinaEntry.IsEditable = true;
			this.VisinaEntry.InvisibleChar = '●';
			this.hbox4.Add(this.VisinaEntry);
			global::Gtk.Box.BoxChild w8 = ((global::Gtk.Box.BoxChild)(this.hbox4[this.VisinaEntry]));
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
			this.hbox5.BorderWidth = ((uint)(5));
			// Container child hbox5.Gtk.Box+BoxChild
			this.bmiLabel = new global::Gtk.Label();
			this.bmiLabel.WidthRequest = 100;
			this.bmiLabel.Name = "bmiLabel";
			this.bmiLabel.LabelProp = global::Mono.Unix.Catalog.GetString("BMI:");
			this.hbox5.Add(this.bmiLabel);
			global::Gtk.Box.BoxChild w10 = ((global::Gtk.Box.BoxChild)(this.hbox5[this.bmiLabel]));
			w10.Position = 0;
			w10.Expand = false;
			w10.Fill = false;
			// Container child hbox5.Gtk.Box+BoxChild
			this.BMIEntry = new global::Gtk.Entry();
			this.BMIEntry.CanFocus = true;
			this.BMIEntry.Name = "BMIEntry";
			this.BMIEntry.IsEditable = false;
			this.BMIEntry.InvisibleChar = '●';
			this.hbox5.Add(this.BMIEntry);
			global::Gtk.Box.BoxChild w11 = ((global::Gtk.Box.BoxChild)(this.hbox5[this.BMIEntry]));
			w11.Position = 1;
			this.vbox1.Add(this.hbox5);
			global::Gtk.Box.BoxChild w12 = ((global::Gtk.Box.BoxChild)(this.vbox1[this.hbox5]));
			w12.Position = 3;
			w12.Expand = false;
			w12.Fill = false;
			// Container child vbox1.Gtk.Box+BoxChild
			this.hbox6 = new global::Gtk.HBox();
			this.hbox6.WidthRequest = 400;
			this.hbox6.Name = "hbox6";
			this.hbox6.Spacing = 6;
			this.hbox6.BorderWidth = ((uint)(18));
			// Container child hbox6.Gtk.Box+BoxChild
			this.PocetnaButton = new global::Gtk.Button();
			this.PocetnaButton.WidthRequest = 100;
			this.PocetnaButton.HeightRequest = 50;
			this.PocetnaButton.CanFocus = true;
			this.PocetnaButton.Name = "PocetnaButton";
			this.PocetnaButton.UseUnderline = true;
			this.PocetnaButton.Label = global::Mono.Unix.Catalog.GetString("Početna");
			global::Gtk.Image w13 = new global::Gtk.Image();
			w13.Pixbuf = global::Stetic.IconLoader.LoadIcon(this, "gtk-home", global::Gtk.IconSize.Menu);
			this.PocetnaButton.Image = w13;
			this.hbox6.Add(this.PocetnaButton);
			global::Gtk.Box.BoxChild w14 = ((global::Gtk.Box.BoxChild)(this.hbox6[this.PocetnaButton]));
			w14.Position = 0;
			w14.Expand = false;
			w14.Fill = false;
			// Container child hbox6.Gtk.Box+BoxChild
			this.BMIButton = new global::Gtk.Button();
			this.BMIButton.WidthRequest = 100;
			this.BMIButton.HeightRequest = 50;
			this.BMIButton.CanFocus = true;
			this.BMIButton.Name = "BMIButton";
			this.BMIButton.UseUnderline = true;
			this.BMIButton.Label = global::Mono.Unix.Catalog.GetString("Izračunaj BMI");
			this.hbox6.Add(this.BMIButton);
			global::Gtk.Box.BoxChild w15 = ((global::Gtk.Box.BoxChild)(this.hbox6[this.BMIButton]));
			w15.Position = 1;
			w15.Expand = false;
			w15.Fill = false;
			w15.Padding = ((uint)(336));
			this.vbox1.Add(this.hbox6);
			global::Gtk.Box.BoxChild w16 = ((global::Gtk.Box.BoxChild)(this.vbox1[this.hbox6]));
			w16.Position = 4;
			w16.Expand = false;
			w16.Fill = false;
			this.Add(this.vbox1);
			if ((this.Child != null))
			{
				this.Child.ShowAll();
			}
			this.DefaultWidth = 616;
			this.DefaultHeight = 416;
			this.Show();
			this.PocetnaButton.Clicked += new global::System.EventHandler(this.Pocetna);
		}
	}
}
