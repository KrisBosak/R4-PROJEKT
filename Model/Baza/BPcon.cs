using System;
using Mono.Data.Sqlite;


namespace R4_Projekt
{
	public class BPcon
	{

		private static string connectionString = "URI=file:R4_Projekt.db3,version=3";

		internal static SqliteConnection con = new SqliteConnection(connectionString);

		internal static void OpenConnection()
		{

			con.Open();

		}


		internal static void CloseConnection()
		{

			con.Close();

		}


	}


}
