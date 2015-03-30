using Flash_It.Droid.Preferences;
using Flash_It.Preferences;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Flash_It.Droid.Helpers
{
    public static class InitialSetupHelper
    {
        public static void CheckInitialSetup()
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

                InitialSetupPreferences.InitialSetupDone = true;
            }
        }
    }
}
