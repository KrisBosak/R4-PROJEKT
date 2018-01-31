using System;

namespace R4_Projekt
{
	public class Konzumacija_hrane_i_picaNode : Gtk.TreeNode
	{
		[Gtk.TreeNodeValue(Column = 0)]
		public String ime_hrane_ili_pica;
		[Gtk.TreeNodeValue(Column = 1)]
		public String tip;
		[Gtk.TreeNodeValue(Column = 2)]
		public float energetska_vrijednost_hrane_ili_pica;

		public Konzumacija_hrane_i_picaNode(Konzumacija_hrane_i_pica khp)
		{
			this.ime_hrane_ili_pica = khp.Ime_hrane_ili_pica;
			this.tip = khp.Tip;
			this.energetska_vrijednost_hrane_ili_pica = khp.Energetska_vrijednost_hrane_ili_pica;
		}
	}
}
