using Android.App;
using Android.OS;
using Android.Support.V7.App;
using Android.Content.PM;
using Android.Widget;

namespace Flash_It.Droid.Views.Activities
{
    [Activity(ScreenOrientation = ScreenOrientation.Portrait, Theme = "@style/ActivityBaseTheme")]
    public class MainActivity : AppCompatActivity
    {
        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);

            SetContentView(Resource.Layout.ActivityMain);

            var versionNumber = FindViewById<TextView>(Resource.Id.TextView_ActivityMain);

            versionNumber.Text = PackageManager.GetPackageInfo(PackageName, 0).VersionName;
        }
    }
}