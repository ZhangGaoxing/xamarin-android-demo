using Android.App;
using Android.Widget;
using Android.OS;
using Android.Content;
using SqliteDemo.Acitvities;
using SqliteDemo.Managers;
using SqliteDemo.Models;

namespace SqliteDemo
{
    [Activity(Label = "SqliteDemo", MainLauncher = true, Theme = "@android:style/Theme.Material.Light")]
    public class MainActivity : Activity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            SetContentView(Resource.Layout.Main);

            Button add = FindViewById<Button>(Resource.Id.main_btn_add);         
            Button del = FindViewById<Button>(Resource.Id.main_btn_del);
            Button que = FindViewById<Button>(Resource.Id.main_btn_que);
            
            add.Click += (s, e) =>
            {
                Intent dialog = new Intent(this, typeof(AddActivity));
                StartActivity(dialog);
            };
            del.Click += (s, e) =>
            {
                Intent dialog = new Intent(this, typeof(DeleteActivity));
                StartActivity(dialog);
            };
            que.Click += (s, e) =>
            {
                Intent dialog = new Intent(this, typeof(QueryActivity));
                StartActivity(dialog);
            };

            SqliteManager<Person> sqlite = new SqliteManager<Person>();
            sqlite.CreateTable();
        }
    }
}

