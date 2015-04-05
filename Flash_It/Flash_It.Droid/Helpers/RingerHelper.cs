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
using Android.Media;
using Flash_It.Droid.Preferences;

namespace Flash_It.Droid.Helpers
{
    public static class RingerHelper
    {
        public static Boolean CheckIfProfileIsAllowed()
        {
            Boolean allowed = false;
            AudioManager am = (AudioManager)Application.Context.GetSystemService(Context.AudioService);

            switch (am.RingerMode)
            {
                case RingerMode.Normal:
                    allowed = RingerPreferences.NormalModeEnabled;
                    break;
                case RingerMode.Vibrate:
                    allowed = RingerPreferences.VibrateModeEnabled;
                    break;
                case RingerMode.Silent:
                    allowed = RingerPreferences.SilentModeEnabled;
                    break;
                default:
                    allowed = true;
                    break;
            }

            return allowed;
        }
    }
}