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
                return Helpers.Preference.GetBoolean("InitialSetupPreferences_Enabled");
            }
            set
            {
                Helpers.Preference.SetBoolean("InitialSetupPreferences_Enabled", value);
            }
        }

        public static int OnTime
        {
            get
            {
                return Helpers.Preference.GetInt("SmsPreferences_OnTime");
            }
            set
            {
                Helpers.Preference.SetInt("SmsPreferences_OnTime", value);
            }
        }

        public static int OffTime
        {
            get
            {
                return Helpers.Preference.GetInt("SmsPreferences_OffTime");
            }
            set
            {
                Helpers.Preference.SetInt("SmsPreferences_OffTime", value);
            }
        }

        public static int NumberOfTimes
        {
            get
            {
                return Helpers.Preference.GetInt("SmsPreferences_NumberOfTimes");
            }
            set
            {
                Helpers.Preference.SetInt("SmsPreferences_NumberOfTimes", value);
            }
        }
    }
}
