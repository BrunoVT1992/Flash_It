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
                return Helpers.Preference.GetBoolean("BatterySaverPreferences_Enabled");
            }
            set
            {
                Helpers.Preference.SetBoolean("BatterySaverPreferences_Enabled", value);
            }
        }

        public static int BatteryMinLevel
        {
            get
            {
                return Helpers.Preference.GetInt("BatterySaverPreferences_BatteryMinLevel");
            }
            set
            {
                Helpers.Preference.SetInt("BatterySaverPreferences_BatteryMinLevel", value);
            }
        }
    }
}