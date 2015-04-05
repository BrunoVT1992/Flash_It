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
using Flash_It.Droid.Helpers;

namespace Flash_It.Droid.Preferences
{
    public static class RingerPreferences
    {
        public static Boolean SilentModeEnabled
        {
            get
            {
                return PreferencesHelper.GetBoolean("RingerPreferences_SilentModeEnabled");
            }
            set
            {
                PreferencesHelper.SetBoolean("RingerPreferences_SilentModeEnabled", value);
            }
        }

        public static Boolean VibrateModeEnabled
        {
            get
            {
                return PreferencesHelper.GetBoolean("RingerPreferences_VibrateModeEnabled");
            }
            set
            {
                PreferencesHelper.SetBoolean("RingerPreferences_VibrateModeEnabled", value);
            }
        }

        public static Boolean NormalModeEnabled
        {
            get
            {
                return PreferencesHelper.GetBoolean("RingerPreferences_NormalModeEnabled");
            }
            set
            {
                PreferencesHelper.SetBoolean("RingerPreferences_NormalModeEnabled", value);
            }
        }
    }
}