using Flash_It.Droid.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Flash_It.Droid.Preferences
{
    public static class CallPreferences
    {
        public static Boolean Enabled
        {
            get
            {
                return Helpers.Preference.GetBoolean("CallPreferences_Enabled");
            }
            set
            {
                Helpers.Preference.SetBoolean("CallPreferences_Enabled", value);
            }
        }

        public static int OnTime
        {
            get
            {
                return Helpers.Preference.GetInt("CallPreferences_OnTime");
            }
            set
            {
                Helpers.Preference.SetInt("CallPreferences_OnTime", value);
            }
        }

        public static int OffTime
        {
            get
            {
                return Helpers.Preference.GetInt("CallPreferences_OffTime");
            }
            set
            {
                Helpers.Preference.SetInt("CallPreferences_OffTime", value);
            }
        }
    }
}
