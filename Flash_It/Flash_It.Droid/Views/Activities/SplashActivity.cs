using Android.App;
using Android.Content;
using Android.OS;
using Android.Support.V7.App;
using Android.Content.PM;

namespace Flash_It.Droid.Views.Activities
{
    [Activity(Theme = "@style/SplashActivityTheme", MainLauncher = true, ScreenOrientation = ScreenOrientation.Portrait)]
    public class SplashActivity : AppCompatActivity
    {
        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);

            var intent = new Intent(this, typeof(MainActivity));
            StartActivity(intent);
            Finish();
        }
    }
}