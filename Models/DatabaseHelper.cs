using System;
using System.Data.SQLite;

namespace ProBizERP.Models
{
    public class DatabaseHelper
    {
        private static string _connectionString = "Data Source=ProBizERP.db;Version=3;";

        public static void InitializeDatabase()
        {
            using var conn = new SQLiteConnection(_connectionString);
            conn.Open();

            string createProductTable = @"
            CREATE TABLE IF NOT EXISTS Products(
                Id INTEGER PRIMARY KEY AUTOINCREMENT,
                Name TEXT NOT NULL,
                Quantity INTEGER NOT NULL,
                Price REAL NOT NULL
            );";

            string createSalesTable = @"
            CREATE TABLE IF NOT EXISTS Sales(
                Id INTEGER PRIMARY KEY AUTOINCREMENT,
                ProductId INTEGER,
                Quantity INTEGER,
                TotalPrice REAL,
                Date TEXT,
                FOREIGN KEY(ProductId) REFERENCES Products(Id)
            );";

            using var cmd = new SQLiteCommand(createProductTable, conn);
            cmd.ExecuteNonQuery();
            cmd.CommandText = createSalesTable;
            cmd.ExecuteNonQuery();
        }

        public static SQLiteConnection GetConnection()
        {
            var conn = new SQLiteConnection(_connectionString);
            conn.Open();
            return conn;
        }
    }
}
