﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using SQLite.Net;
using SQLite.Net.Platform.XamarinAndroid;

namespace SqliteDemo.Managers
{
    class SqliteManager<T> where T : class
    {
        /// <summary>
        /// 数据库文件路径
        /// </summary>
        private string dbPath = string.Empty;

        public string DbPath
        {
            get
            {
                if (string.IsNullOrEmpty(dbPath))
                {
                    dbPath = Path.Combine(System.Environment.GetFolderPath(System.Environment.SpecialFolder.Personal), "info.db3");
                }

                return dbPath;
            }
        }

        /// <summary>
        /// 数据库连接
        /// </summary>
        public SQLiteConnection DbConnection
        {
            get
            {
                return new SQLiteConnection(new SQLitePlatformAndroid() ,DbPath);
            }
        }

        public SqliteManager()
        {

        }

        public SqliteManager(string dbPath)
        {
            this.dbPath = dbPath;
        }

        /// <summary>
        /// 创建表
        /// </summary>
        public void CreateTable()
        {
            using (var db = DbConnection)
            {
                var c = db.CreateTable<T>();
            }
        }

        /// <summary>
        /// 插入数据
        /// </summary>
        /// <param name="item">插入值</param>
        public void Insert(T item)
        {
            using (var db = DbConnection)
            {
                db.Insert(item);
            }
        }

        /// <summary>
        /// 插入数据
        /// </summary>
        /// <param name="item">插入值</param>
        public void InsertAll(IEnumerable<T> list)
        {
            using (var db = DbConnection)
            {
                db.InsertAll(list);
            }
        }

        /// <summary>
        /// 删除数据
        /// </summary>
        /// <param name="item">删除值</param>
        public void Delete(T item)
        {
            using (var db = DbConnection)
            {
                db.Delete(item);
            }
        }

        /// <summary>
        /// 更新数据
        /// </summary>
        /// <param name="item">更新值</param>
        public void Update(T item)
        {
            using (var db = DbConnection)
            {
                db.Update(item);
            }
        }

        /// <summary>
        /// 查询所有数据
        /// </summary>
        /// <returns>表中所有数据</returns>
        public List<T> QueryAll()
        {
            using (var db = DbConnection)
            {
                return db.Table<T>().ToList();
            }
        }
    }
}