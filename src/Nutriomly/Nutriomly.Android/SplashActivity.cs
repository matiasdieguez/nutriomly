
using Android.App;
using Android.Content;
using Android.Support.V7.App;

namespace Nutriomly.Droid
{
    [Activity(Label = "Nutriomly", Theme = "@style/MyTheme.Splash", MainLauncher = true, NoHistory = true)]
    public class SplashActivity : AppCompatActivity
    {
        protected override void OnResume()
        {
            base.OnResume();
            StartActivity(new Intent(Application.Context, typeof(MainActivity)));
        }
    }
}