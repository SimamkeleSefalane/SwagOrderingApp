using SQLite;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace SwagApp
{
    public class OrderedItemsDatabase
    {
        static SQLiteConnection Database;

        public static OrderedItemsDatabase Instance
        {
            get
            {
                var instance = new OrderedItemsDatabase();
                CreateTableResult result = Database.CreateTable<OrderedItems>();
                return instance;

            }

        }

        public static class Constants
        {
            public const string DatabaseFilename = "TodoSQLite.db3";

            public const SQLite.SQLiteOpenFlags Flags =
                
                SQLite.SQLiteOpenFlags.ReadWrite |
                
                SQLite.SQLiteOpenFlags.Create |
            
                SQLite.SQLiteOpenFlags.SharedCache;

            public static string DatabasePath
            {
                get
                {
                    var basePath = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData);
                    return Path.Combine(basePath, DatabaseFilename);
                }
            }
        }
        public OrderedItemsDatabase()
        {

            Database = new SQLiteConnection(Constants.DatabasePath, Constants.Flags);
        }
        public List <OrderedItems> GetOrderItems()
        {
            return Database.Table<OrderedItems>().ToList();
        }
        public List<OrderedItems> OrderedItemsNotDone()
        {
            return Database.Query<OrderedItems>("SELECT * FROM [OrderedItems] WHERE [Done] = 0");

        }
        public OrderedItems GetOrderedItems(int id)
        {
            return Database.Table<OrderedItems>().Where(i => i.Id == id).FirstOrDefault();
        }
        public int SaveOrder(OrderedItems items)
        {
            if (items.Id != 0)
            {
                return Database.Update(items);
            }
            else
            {
                return Database.Insert(items);
            }
            
        }
        public int DeleteItem(OrderedItems items)
        {
            return Database.Delete(items);
        }

    }
}