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
using Flash_It.Droid.Preferences;

namespace Flash_It.Droid.Helpers
{
    public static class BatteryHelper
    {
        public static int GetBatteryLevel()
        {
            var filter = new IntentFilter(Intent.ActionBatteryChanged);
            var battery = Application.Context.RegisterReceiver(null, filter);

            return battery.GetIntExtra(BatteryManager.ExtraLevel, -1);
        }

        public static Boolean CheckBatteryLevelAllowed()
        {
            if (BatterySaverPreferences.BatterySaverEnabled)
            {
                if (BatterySaverPreferences.BatteryMinLevel < GetBatteryLevel())
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else
            {
                return true;
            }
        }
    }
}