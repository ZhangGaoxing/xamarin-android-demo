using Android.App;
using Android.Widget;
using Android.OS;
using Android.Content;

namespace ActivityStates
{
    [Activity(Label = "ActivityStates", MainLauncher = true, Icon = "@drawable/icon")]
    public class MainActivity : Activity
    {
        TextView txtLog;        // 用于显示信息

        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);
            SetContentView (Resource.Layout.Main);
            // 获取控件
            Button btnDialog = FindViewById<Button>(Resource.Id.btnDialog);
            Button btnNormal = FindViewById<Button>(Resource.Id.btnNormal);
            txtLog = FindViewById<TextView>(Resource.Id.txtLog);
            // 输出信息
            txtLog.Text += "OnCreate()\n";

            btnDialog.Click += (sender, e) =>
            {
                Intent dialog = new Intent(this, typeof(Activities.DialogActivity));
                StartActivity(dialog);
            };

            btnNormal.Click += (sender, e) =>
            {
                Intent normal = new Intent(this, typeof(Activities.NormalActivity));
                StartActivity(normal);
            };
        }

        protected override void OnStart()
        {
            base.OnStart();
            txtLog.Text += "OnCreate()\n";
        }

        protected override void OnResume()
        {
            base.OnResume();
            txtLog.Text += "OnResume()\n";
        }

        protected override void OnPause()
        {
            base.OnPause();
            txtLog.Text += "OnPause()\n";
        }

        protected override void OnStop()
        {
            base.OnStop();
            txtLog.Text += "OnStop()\n";
        }

        protected override void OnRestart()
        {
            base.OnRestart();
            txtLog.Text += "OnRestart()\n";
        }

        protected override void OnDestroy()
        {
            base.OnDestroy();
            Toast.MakeText(this, "OnDestroy()", ToastLength.Short).Show();
        }
    }
}

