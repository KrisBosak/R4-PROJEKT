using System;
using Gtk;
 
namespace R4_Projekt{
	
	class MainClass{
		public static void Main(string[] args){
			Application.Init();
			Gtk.Settings.Default.SetLongProperty ("gtk-button-images", 1, "");
			PrijavaWindow win = new PrijavaWindow();
			win.Show();
			Application.Run();


			Console.ReadKey();
		}
	}
}
