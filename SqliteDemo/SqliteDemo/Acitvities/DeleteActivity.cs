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
    [Activity(Label = "DeleteActivity")]
    public class DeleteActivity : Activity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            SetContentView(Resource.Layout.DeleteLayout);

            Button del = FindViewById<Button>(Resource.Id.del_btn_del);
            EditText id = FindViewById<EditText>(Resource.Id.del_edit_id);

            del.Click += (s, e) =>
            {
                SqliteManager<Person> sqlite = new SqliteManager<Person>();

                sqlite.DbConnection.Execute($"delete from Person where id = '{id.Text}'");
            };
        }
    }
}