using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using SQLite.Net.Attributes;

namespace SqliteDemo.Models
{
    public class Person
    {
        [PrimaryKey, AutoIncrement]
        public int ID { get; set; }

        public string Name { get; set; }

        public string Sex { get; set; }

        public int Age { get; set; }
    }
}