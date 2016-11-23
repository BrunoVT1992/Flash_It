using Flash_It.Droid.Preferences;

namespace Flash_It.Droid.Helpers
{
    public class InitialSetup
    {
        public void DoInitialSetup()
        {
            if (!InitialSetupPreferences.InitialSetupDone)
            {
                SmsPreferences.Enabled = true;
                SmsPreferences.OnTime = 200;
                SmsPreferences.OffTime = 200;
                SmsPreferences.NumberOfTimes = 2;

                CallPreferences.Enabled = true;
                CallPreferences.OnTime = 300;
                CallPreferences.OffTime = 300;

                RingerPreferences.NormalModeEnabled = true;
                RingerPreferences.VibrateModeEnabled = true;
                RingerPreferences.SilentModeEnabled = true;

                BatterySaverPreferences.Enabled = true;
                BatterySaverPreferences.BatteryMinLevel = 5;

                InitialSetupPreferences.InitialSetupDone = true;
            }
        }
    }
}
