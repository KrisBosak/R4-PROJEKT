using System;
using Mono.Data.Sqlite;

namespace R4_Projekt
{
	public static class BPhranaipice
	{

		private static System.Globalization.CultureInfo customCulture;


		public static void hranaipiceT()
		{

			SqliteCommand com = BPcon.con.CreateCommand();
			com.CommandText = @"
							
							CREATE TABLE IF NOT EXISTS HranaiPice (
	
								ime_hrane_ili_pica text NOT NULL, 
								tip text NOT NULL,
								energetska_vrijednost_hrane_ili_pica real NOT NULL)";

			com.ExecuteNonQuery();
			com.Dispose();
			SqliteCommand dbInsertCmd = BPcon.con.CreateCommand();

			dbInsertCmd.CommandText = (@"INSERT INTO HranaiPice (ime_hrane_ili_pica, tip, energetska_vrijednost_hrane_ili_pica) 						
											VALUES ('Piletina (bijelo meso)', 'hrana', '144 kcal');
										INSERT INTO HranaiPice (ime_hrane_ili_pica, tip, energetska_vrijednost_hrane_ili_pica) 
											VALUES ('Svinjetina', 'hrana', '345 kcal');
										INSERT INTO HranaiPice (ime_hrane_ili_pica, tip, energetska_vrijednost_hrane_ili_pica) 
											VALUES ('Pileća salama','hrana', '197 kcal');
										INSERT INTO HranaiPice(ime_hrane_ili_pica, tip, energetska_vrijednost_hrane_ili_pica)
											VALUES('Čaj', 'Piće', '50 kcal');
										INSERT INTO HranaiPice(ime_hrane_ili_pica, tip, energetska_vrijednost_hrane_ili_pica)
											VALUES('Paprikaš', 'hrana', '320 kcal');
										INSERT INTO HranaiPice(ime_hrane_ili_pica, tip, energetska_vrijednost_hrane_ili_pica)
											VALUES('Sarma','hrana', '450 kcal');
										INSERT INTO HranaiPice(ime_hrane_ili_pica, tip, energetska_vrijednost_hrane_ili_pica)
											VALUES('Cedevita', 'piće', '90 kcal');
										INSERT INTO HranaiPice(ime_hrane_ili_pica, tip, energetska_vrijednost_hrane_ili_pica)
											VALUES('Pivo', 'Piće', '200 kcal');
										INSERT INTO HranaiPice(ime_hrane_ili_pica, tip, energetska_vrijednost_hrane_ili_pica)
											VALUES('Burek','hrana', '410 kcal');
										INSERT INTO HranaiPice(ime_hrane_ili_pica, tip, energetska_vrijednost_hrane_ili_pica)
											VALUES('Pizza', 'hrana', '390 kcal');
										INSERT INTO HranaiPice(ime_hrane_ili_pica, tip, energetska_vrijednost_hrane_ili_pica)
											VALUES('Vino', 'Piće', '100 kcal');
										INSERT INTO HranaiPice(ime_hrane_ili_pica, tip, energetska_vrijednost_hrane_ili_pica)
											VALUES('Kruh','hrana', '170 kcal');
										INSERT INTO HranaiPice(ime_hrane_ili_pica, tip, energetska_vrijednost_hrane_ili_pica)
											VALUES('Voda', 'Piće', '1 kcal');
										INSERT INTO HranaiPice(ime_hrane_ili_pica, tip, energetska_vrijednost_hrane_ili_pica)
											VALUES('Spaghete', 'hrana', '345 kcal');
										INSERT INTO HranaiPice(ime_hrane_ili_pica, tip, energetska_vrijednost_hrane_ili_pica)
											VALUES('Limunada','Piće', '100 kcal');
										INSERT INTO HranaiPice(ime_hrane_ili_pica, tip, energetska_vrijednost_hrane_ili_pica)
											VALUES('Lasagne', 'hrana', '300 kcal');
										INSERT INTO HranaiPice(ime_hrane_ili_pica, tip, energetska_vrijednost_hrane_ili_pica)
											VALUES('Buncek', 'hrana', '281 kcal');
										INSERT INTO HranaiPice(ime_hrane_ili_pica, tip, energetska_vrijednost_hrane_ili_pica)
											VALUES('Čvarci','hrana', '300 kcal');
										INSERT INTO HranaiPice(ime_hrane_ili_pica, tip, energetska_vrijednost_hrane_ili_pica)
											VALUES('Jack Daniels', 'Piće', '333 kcal');
										INSERT INTO HranaiPice(ime_hrane_ili_pica, tip, energetska_vrijednost_hrane_ili_pica)
											VALUES('Kava', 'Piće', '50 kcal');
										INSERT INTO HranaiPice(ime_hrane_ili_pica, tip, energetska_vrijednost_hrane_ili_pica)
											VALUES('Buhtla','hrana', '250 kcal');
										INSERT INTO HranaiPice(ime_hrane_ili_pica, tip, energetska_vrijednost_hrane_ili_pica)
											VALUES('Sok od jagode', 'Piće', '111 kcal');
										INSERT INTO HranaiPice(ime_hrane_ili_pica, tip, energetska_vrijednost_hrane_ili_pica)
											VALUES('Artičoke', 'hrana', '90 kcal');
										INSERT INTO HranaiPice(ime_hrane_ili_pica, tip, energetska_vrijednost_hrane_ili_pica)
											VALUES('Šparoge','hrana', '100 kcal');");

			dbInsertCmd.ExecuteNonQuery();
			dbInsertCmd.Dispose();
			customCulture = (System.Globalization.CultureInfo)System.Threading.Thread.CurrentThread.CurrentCulture.Clone();
			customCulture.NumberFormat.NumberDecimalSeparator = ".";
			System.Threading.Thread.CurrentThread.CurrentCulture = customCulture;

		}

		public static void SpremiHranaiPice(ref Konzumacija_hrane_i_pica hp)
		{

			SqliteCommand com = BPcon.con.CreateCommand();

			com.CommandText = String.Format(@"INSERT INTO HranaiPice (ime_hrane_ili_pica, tip, energetska_vrijednost_hrane_ili_pica)
													VALUES ('{0}', '{1}','{2}')",
													  hp.Ime_hrane_ili_pica, hp.Tip, hp.Energetska_vrijednost_hrane_ili_pica);

			com.ExecuteNonQuery();
			com.Dispose();

		}
	}
}