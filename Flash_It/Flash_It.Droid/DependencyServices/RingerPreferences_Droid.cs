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
using Flash_It.DependencyServices;
using Flash_It.Droid.Preferences;
using Flash_It.Droid.DependencyServices;
using Xamarin.Forms;

[assembly: Dependency(typeof(RingerPreferences_Droid))]

namespace Flash_It.Droid.DependencyServices
{
    public class RingerPreferences_Droid : IRingerPreferences
    {
        public bool GetNormalModeEnabled()
        {
            return RingerPreferences.NormalModeEnabled;
        }

        public bool GetSilentModeEnabled()
        {
            return RingerPreferences.SilentModeEnabled;
        }

        public bool GetVibrateModeEnabled()
        {
            return RingerPreferences.VibrateModeEnabled;
        }

        public void SetNormalModeEnabled(bool enabled)
        {
            RingerPreferences.NormalModeEnabled = enabled;
        }

        public void SetSilentModeEnabled(bool enabled)
        {
            RingerPreferences.SilentModeEnabled = enabled;
        }

        public void SetVibrateModeEnabled(bool enabled)
        {
            RingerPreferences.VibrateModeEnabled = enabled;
        }
    }
}