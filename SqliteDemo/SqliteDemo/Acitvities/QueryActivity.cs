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
using SqliteDemo.Managers;
using SqliteDemo.Models;

namespace SqliteDemo.Acitvities
{
    [Activity(Label = "QueryActivity")]
    public class QueryActivity : Activity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            SetContentView(Resource.Layout.QueryLayout);

            TextView res = FindViewById<TextView>(Resource.Id.que_text_res);

            SqliteManager<Person> sqlite = new SqliteManager<Person>();
            var list = sqlite.QueryAll();
            foreach (var item in list)
            {
                res.Text += $"ID:{item.ID}  Name:{item.Name}  Sex:{item.Sex}  Age:{item.Age}\n";
            }
        }
    }
}