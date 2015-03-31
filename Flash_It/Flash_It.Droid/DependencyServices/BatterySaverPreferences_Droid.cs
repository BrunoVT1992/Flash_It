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

[assembly: Dependency(typeof(BatterySaverPreferences_Droid))]

namespace Flash_It.Droid.DependencyServices
{
    public class BatterySaverPreferences_Droid : IBatterySaverPreferences
    {
        public int GetBatteryMinLevel()
        {
            return BatterySaverPreferences.BatteryMinLevel;
        }

        public bool GetEnabled()
        {
            return BatterySaverPreferences.Enabled;
        }

        public void SetBatteryMinLevel(int batteryMinLevel)
        {
            BatterySaverPreferences.BatteryMinLevel = batteryMinLevel;
        }

        public void SetEnabled(bool enabled)
        {
            BatterySaverPreferences.Enabled = enabled;
        }
    }
}