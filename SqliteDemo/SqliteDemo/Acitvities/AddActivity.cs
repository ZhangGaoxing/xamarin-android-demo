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
    [Activity(Label = "AddActivity")]
    public class AddActivity : Activity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            SetContentView(Resource.Layout.AddLayout);

            Button add = FindViewById<Button>(Resource.Id.add_btn_add);
            EditText name = FindViewById<EditText>(Resource.Id.add_edit_name);
            EditText sex = FindViewById<EditText>(Resource.Id.add_edit_sex);
            EditText age = FindViewById<EditText>(Resource.Id.add_edit_age);

            add.Click += (s, e) =>
            {
                SqliteManager<Person> sqlite = new SqliteManager<Person>();

                sqlite.Insert(new Person
                {
                    Name = name.Text,
                    Sex = sex.Text,
                    Age = Convert.ToInt32(age.Text)
                });
            };
        }
    }
}