
// This file has been generated by the GUI designer. Do not modify.
namespace R4_Projekt
{
	public partial class Stat_podaciWindow
	{
		private global::Gtk.VBox vbox1;

		private global::Gtk.HBox hbox1;

		private global::Gtk.Label usernameLabel;

		private global::Gtk.HBox hbox3;

		private global::Gtk.Button NazadButton;

		private global::Gtk.Button PocetnaButton;

		protected virtual void Build()
		{
			global::Stetic.Gui.Initialize(this);
			// Widget R4_Projekt.Stat_podaciWindow
			this.Name = "R4_Projekt.Stat_podaciWindow";
			this.Title = global::Mono.Unix.Catalog.GetString("Statisticki_podaci");
			this.WindowPosition = ((global::Gtk.WindowPosition)(3));
			// Container child R4_Projekt.Stat_podaciWindow.Gtk.Container+ContainerChild
			this.vbox1 = new global::Gtk.VBox();
			this.vbox1.Name = "vbox1";
			this.vbox1.Spacing = 6;
			// Container child vbox1.Gtk.Box+BoxChild
			this.hbox1 = new global::Gtk.HBox();
			this.hbox1.WidthRequest = 400;
			this.hbox1.Name = "hbox1";
			this.hbox1.Spacing = 6;
			// Container child hbox1.Gtk.Box+BoxChild
			this.usernameLabel = new global::Gtk.Label();
			this.usernameLabel.Name = "usernameLabel";
			this.usernameLabel.LabelProp = global::Mono.Unix.Catalog.GetString("username");
			this.hbox1.Add(this.usernameLabel);
			global::Gtk.Box.BoxChild w1 = ((global::Gtk.Box.BoxChild)(this.hbox1[this.usernameLabel]));
			w1.Position = 0;
			w1.Expand = false;
			w1.Fill = false;
			w1.Padding = ((uint)(646));
			this.vbox1.Add(this.hbox1);
			global::Gtk.Box.BoxChild w2 = ((global::Gtk.Box.BoxChild)(this.vbox1[this.hbox1]));
			w2.Position = 0;
			w2.Expand = false;
			w2.Fill = false;
			// Container child vbox1.Gtk.Box+BoxChild
			this.hbox3 = new global::Gtk.HBox();
			this.hbox3.WidthRequest = 400;
			this.hbox3.Name = "hbox3";
			this.hbox3.Spacing = -474;
			this.hbox3.BorderWidth = ((uint)(11));
			// Container child hbox3.Gtk.Box+BoxChild
			this.NazadButton = new global::Gtk.Button();
			this.NazadButton.WidthRequest = 100;
			this.NazadButton.HeightRequest = 50;
			this.NazadButton.CanFocus = true;
			this.NazadButton.Name = "NazadButton";
			this.NazadButton.UseUnderline = true;
			this.NazadButton.Label = global::Mono.Unix.Catalog.GetString("Nazad");
			global::Gtk.Image w3 = new global::Gtk.Image();
			w3.Pixbuf = global::Stetic.IconLoader.LoadIcon(this, "gtk-go-back", global::Gtk.IconSize.Menu);
			this.NazadButton.Image = w3;
			this.hbox3.Add(this.NazadButton);
			global::Gtk.Box.BoxChild w4 = ((global::Gtk.Box.BoxChild)(this.hbox3[this.NazadButton]));
			w4.Position = 0;
			w4.Expand = false;
			w4.Fill = false;
			w4.Padding = ((uint)(486));
			// Container child hbox3.Gtk.Box+BoxChild
			this.PocetnaButton = new global::Gtk.Button();
			this.PocetnaButton.WidthRequest = 100;
			this.PocetnaButton.HeightRequest = 50;
			this.PocetnaButton.CanFocus = true;
			this.PocetnaButton.Name = "PocetnaButton";
			this.PocetnaButton.UseUnderline = true;
			this.PocetnaButton.Label = global::Mono.Unix.Catalog.GetString("Početna");
			global::Gtk.Image w5 = new global::Gtk.Image();
			w5.Pixbuf = global::Stetic.IconLoader.LoadIcon(this, "gtk-home", global::Gtk.IconSize.Menu);
			this.PocetnaButton.Image = w5;
			this.hbox3.Add(this.PocetnaButton);
			global::Gtk.Box.BoxChild w6 = ((global::Gtk.Box.BoxChild)(this.hbox3[this.PocetnaButton]));
			w6.Position = 1;
			w6.Expand = false;
			w6.Fill = false;
			this.vbox1.Add(this.hbox3);
			global::Gtk.Box.BoxChild w7 = ((global::Gtk.Box.BoxChild)(this.vbox1[this.hbox3]));
			w7.Position = 1;
			w7.Expand = false;
			w7.Fill = false;
			this.Add(this.vbox1);
			if ((this.Child != null))
			{
				this.Child.ShowAll();
			}
			this.DefaultWidth = 744;
			this.DefaultHeight = 477;
			this.Show();
			this.NazadButton.Clicked += new global::System.EventHandler(this.Nazad);
			this.PocetnaButton.Clicked += new global::System.EventHandler(this.Pocetna);
		}
	}
}
