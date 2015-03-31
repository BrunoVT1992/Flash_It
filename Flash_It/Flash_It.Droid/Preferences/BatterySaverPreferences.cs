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
    public static class BatterySaverPreferences
    {
        public static Boolean Enabled
        {
            get
            {
                return PreferencesHelper.GetBoolean("BatterySaverPreferences_Enabled");
            }
            set
            {
                PreferencesHelper.SetBoolean("BatterySaverPreferences_Enabled", value);
            }
        }

        public static int BatteryMinLevel
        {
            get
            {
                return PreferencesHelper.GetInt("BatterySaverPreferences_BatteryMinLevel");
            }
            set
            {
                PreferencesHelper.SetInt("BatterySaverPreferences_BatteryMinLevel", value);
            }
        }
    }
}