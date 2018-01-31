using System;
using Gtk;
using System.Collections.Generic;
using Mono.Data.Sqlite;

namespace R4_Projekt
{
	public partial class UlazWindow : Gtk.Window
	{
		public List<Konzumacija_hrane_i_pica> lkhp = new List<Konzumacija_hrane_i_pica>();

		float kalorije = 0;
		public UlazWindow() : base(Gtk.WindowType.Toplevel)
		{
			Build();

			buttonOdaberi.Clicked += Odaberi;

			BPcon.OpenConnection();

			BPhranaipice.hranaipiceT();

			List<Konzumacija_hrane_i_pica> lkhp = new List<Konzumacija_hrane_i_pica>();

			SqliteCommand c = BPcon.con.CreateCommand();
			c.CommandText = String.Format(@"SELECT * FROM HranaiPice");
			SqliteDataReader reader = c.ExecuteReader();

			while (reader.Read())
			{
				Konzumacija_hrane_i_pica k = new Konzumacija_hrane_i_pica(
					(string)reader["ime_hrane_ili_pica"],
					(string)reader["tip"],
					(float)reader["energetska_vrijednost_hrane_ili_pica"]);
				lkhp.Add(k);
			}
			c.Dispose();

			Konzumacija_hrane_i_picaNodeStore khpPresenter = new Konzumacija_hrane_i_picaNodeStore();
			khpPresenter.dodaj(lkhp);

			nodeview1.NodeStore = khpPresenter;
			nodeview1.AppendColumn("Ime", new Gtk.CellRendererText(), "text", 0);
			nodeview1.AppendColumn("Tip", new Gtk.CellRendererText(), "text", 1);
			nodeview1.AppendColumn("Energetska vrijednost", new Gtk.CellRendererText(), "text", 2);

			BPcon.CloseConnection();
		}

		protected void Pocetna(object sender, EventArgs e)
		{
			PocetnaWindow win = new PocetnaWindow();
			win.Show();
			this.Destroyed -= Pocetna;
			this.Destroy();
		}


		protected void Odaberi(object sender, EventArgs e)
		{
			
			var kal = (Konzumacija_hrane_i_picaNode)nodeview1.NodeSelection.SelectedNode;
			kalorije = kal.energetska_vrijednost_hrane_ili_pica + kalorije;
			UkupnoKcalLabel.LabelProp = kalorije.ToString();

			if (kalorije > 2500) { 
				Dialog d = new Gtk.MessageDialog(this, DialogFlags.Modal, MessageType.Warning, ButtonsType.Ok, 
				                                 "Možda bi htjeli nešto manje kalorija unijeti! :)");
				d.Run();
				d.Destroy();
			}
		}
	}
}