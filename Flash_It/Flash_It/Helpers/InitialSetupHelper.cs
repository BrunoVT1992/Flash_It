using Flash_It.Preferences;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Flash_It.Helpers
{
    public static class InitialSetupHelper
    {
        public static void CheckInitialSetup()
        {
            if (!InitialSetupPreferences.InitialSetupDone)
            {
                SmsPreferences.Enabled = true;
                SmsPreferences.OnTime = 150;
                SmsPreferences.OffTime = 150;
                SmsPreferences.NumberOffTimes = 2;

                CallPreferences.Enabled = true;
                CallPreferences.OnTime = 300;
                CallPreferences.OffTime = 300;

                InitialSetupPreferences.InitialSetupDone = true;
            }
        }
    }
}
