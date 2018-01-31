using System;
using System.Collections.Generic;
using Mono.Data.Sqlite;

namespace R4_Projekt
{
	public class BPkorisnik
	{

		public static void korisnikT()
		{
		SqliteCommand com = BPcon.con.CreateCommand();
		com.CommandText = (@"
				
					CREATE TABLE IF NOT EXISTS korisnik (
						
							ime text NOT NULL,
							prezime text NOT NULL,
							nadimak text NOT NULL PRIMARY KEY,
							lozinka text NOT NULL,
							email text NOT NULL)");

		com.ExecuteNonQuery();
		com.Dispose();
		}

		public static List<Korisnik> DohvatiSveKorisnike()
		{

			List<Korisnik> listaKorisnika = new List<Korisnik>();

			BPcon.OpenConnection();

			SqliteCommand command = BPcon.con.CreateCommand();

			command.CommandText = "SELECT nadimak, lozinka FROM korisnik";

			SqliteDataReader reader = command.ExecuteReader();

			while (reader.Read())
			{

				Korisnik k = new Korisnik();

				k.Nadimak = (string)reader["nadimak"];
				k.Lozinka = (string)reader["lozinka"];

				listaKorisnika.Add(k);
			}

			reader.Dispose();
			command.Dispose();

			BPcon.CloseConnection();

			return listaKorisnika;


		}

		/*public static void Spremi(Korisnik k)
		{

			//BPcon.OpenConnection();
			SqliteCommand com = BPcon.con.CreateCommand();

			com.CommandText = String.Format(@"INSERT INTO korisnik (ime, prezime, nadimak, lozinka, email, godine, visina, tezina) 
														VALUES ('{0}','{1}','{2}','{3}','{4}','{5}','{6}',{7})",
			                   k.Ime, k.Prezime, k.Nadimak, k.Lozinka, k.Email,k.Godine, k.Visina, k.Tezina);


			com.ExecuteNonQuery();
			com.Dispose();



			//BPcon.CloseConnection();


		}*/
	}
}
