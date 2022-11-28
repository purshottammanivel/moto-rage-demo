using Flyers_Motor_Sports.DatabaseTable;
using SQLite;
using System;
using System.IO;

namespace Flyers_Motor_Sports.Database
{
    public class CoreDatabase
    {
        public static SQLiteAsyncConnection Database;
        public const string DatabaseFilename = "FlyersMotorSports.db3";

        public const SQLite.SQLiteOpenFlags Flags =
         // open the database in read/write mode
         SQLite.SQLiteOpenFlags.ReadWrite |
         // create the database if it doesn't exist
         SQLite.SQLiteOpenFlags.Create |
         // enable multi-threaded database access
         SQLite.SQLiteOpenFlags.SharedCache;

        public CoreDatabase()
        {
            var basePath = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData);
            basePath = Path.Combine(basePath, DatabaseFilename);
            Database = new SQLiteAsyncConnection(basePath, Flags);
            this.CreateTable();
        }

        private async void CreateTable()
        {
            CreateTableResult result = await Database.CreateTableAsync<Department>();
            CreateTableResult jobsresult = await Database.CreateTableAsync<Jobs>();
        }
    }
}
