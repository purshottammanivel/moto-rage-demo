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
            string basePath = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData);
            string dbFilePath = Path.Combine(basePath, DatabaseFilename);
            Database = new SQLiteAsyncConnection(dbFilePath, Flags);
            if (!File.Exists(dbFilePath))
            {
                this.CreateTable();
            }
        }

        //private async void CreateTable()
        //{
        //    CreateTableResult result = await Database.CreateTableAsync<Job>();
        //    CreateTableResult jobsresult = await Database.CreateTableAsync<Employee>();
        //    CreateTableResult modificationResult = await Database.CreateTableAsync<Modification>();
        //    CreateTableResult cardResult = await Database.CreateTableAsync<Car>();
        //}

        private async void CreateTable()
        {
            CreateTableResult result = await Database.CreateTableAsync<Job>();
            CreateTableResult jobsresult = await Database.CreateTableAsync<Employee>();
            CreateTableResult modificationResult = await Database.CreateTableAsync<Modification>();
        }
    }
}
