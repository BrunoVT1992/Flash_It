using System;
using Android.App;
using Android.Content;
using Android.OS;
using Flash_It.Droid.Preferences;

namespace Flash_It.Droid.Utils
{
    public class BatteryUtil
    {
        public int GetBatteryLevel()
        {
            var filter = new IntentFilter(Intent.ActionBatteryChanged);
            var battery = Application.Context.RegisterReceiver(null, filter);

            return battery.GetIntExtra(BatteryManager.ExtraLevel, -1);
        }

        public Boolean CheckBatteryLevelAllowed()
        {
            if (BatterySaverPreferences.Enabled)
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