using System;
using System.Collections.Generic;

namespace R4_Projekt{
	public class Konzumacija_hrane_i_picaNodeStore : Gtk.NodeStore{
		public Konzumacija_hrane_i_picaNodeStore() : base(typeof(Konzumacija_hrane_i_picaNode)){
		}
		public void Add(Konzumacija_hrane_i_pica k){
			this.AddNode(new Konzumacija_hrane_i_picaNode(k));
		}
		public void dodaj(List<Konzumacija_hrane_i_pica> khp){
			foreach (Konzumacija_hrane_i_pica k in khp){
				this.Add(k);
			}
		}
	}
}


