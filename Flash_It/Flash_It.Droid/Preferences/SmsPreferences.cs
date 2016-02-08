using Flash_It.Droid.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Flash_It.Droid.Preferences
{
    public static class SmsPreferences
    {
        public static Boolean Enabled
        {
            get
            {
                return PreferencesHelper.GetBoolean("InitialSetupPreferences_Enabled");
            }
            set
            {
                PreferencesHelper.SetBoolean("InitialSetupPreferences_Enabled", value);
            }
        }

        public static int OnTime
        {
            get
            {
                return PreferencesHelper.GetInt("SmsPreferences_OnTime");
            }
            set
            {
                PreferencesHelper.SetInt("SmsPreferences_OnTime", value);
            }
        }

        public static int OffTime
        {
            get
            {
                return PreferencesHelper.GetInt("SmsPreferences_OffTime");
            }
            set
            {
                PreferencesHelper.SetInt("SmsPreferences_OffTime", value);
            }
        }

        public static int NumberOfTimes
        {
            get
            {
                return PreferencesHelper.GetInt("SmsPreferences_NumberOfTimes");
            }
            set
            {
                PreferencesHelper.SetInt("SmsPreferences_NumberOfTimes", value);
            }
        }
    }
}
