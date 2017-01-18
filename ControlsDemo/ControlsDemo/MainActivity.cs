using Android.App;
using Android.Widget;
using Android.OS;

namespace ControlsDemo
{
    [Activity(Label = "ControlsDemo", MainLauncher = true, Icon = "@drawable/icon")]
    public class MainActivity : Activity
    {
        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);

            SetContentView (Resource.Layout.Main);

            Button button = FindViewById<Button>(Resource.Id.button);
            button.Click += (sender, e) =>
            {
                Toast.MakeText(this, "Button Click", ToastLength.Short).Show();
            };

            Button btnGetString = FindViewById<Button>(Resource.Id.btnGetString);
            EditText editText = FindViewById<EditText>(Resource.Id.editText);
            btnGetString.Click += (sender, e) =>
            {
                string s = editText.Text;
                Toast.MakeText(this, $"EditText:{s}", ToastLength.Short).Show();
            };

            Button btnAlertDialog = FindViewById<Button>(Resource.Id.btnAlertDialog);
            btnAlertDialog.Click += (sender, e) =>
            {
                AlertDialog.Builder alert = new AlertDialog.Builder(this);

                alert.SetTitle("AlertDialog");
                alert.SetMessage("Something important");
                alert.SetCancelable(false);
                alert.SetPositiveButton("OK", (s1, e1) =>
                {
                    Toast.MakeText(this, "Clicked OK", ToastLength.Short).Show();
                });
                alert.SetNegativeButton("Cancel", (s2, e2) =>
                 {
                     Toast.MakeText(this, "Clicked Cancel", ToastLength.Short).Show();
                 });

                alert.Show();
            };

            Button btnProgressDialog = FindViewById<Button>(Resource.Id.btnProgressDialog);
            btnProgressDialog.Click += (sender, e) =>
            {
                ProgressDialog progress = new ProgressDialog(this);
                progress.SetTitle("ProgressDialog");
                progress.SetMessage("Loading...");
                progress.SetCancelable(true);
                progress.Show();
            };
        }
    }
}

