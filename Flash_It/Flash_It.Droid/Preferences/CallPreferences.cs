using Flash_It.DependencyServices;
using Flash_It.Droid.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Flash_It.Droid.Preferences
{
    public static class CallPreferences
    {
        public static Boolean Enabled
        {
            get
            {
                return PreferencesHelper.GetBoolean("CallPreferences_Enabled");
            }
            set
            {
                PreferencesHelper.SetBoolean("CallPreferences_Enabled", value);
            }
        }

        public static int OnTime
        {
            get
            {
                return PreferencesHelper.GetInt("CallPreferences_OnTime");
            }
            set
            {
                PreferencesHelper.SetInt("CallPreferences_OnTime", value);
            }
        }

        public static int OffTime
        {
            get
            {
                return PreferencesHelper.GetInt("CallPreferences_OffTime");
            }
            set
            {
                PreferencesHelper.SetInt("CallPreferences_OffTime", value);
            }
        }
    }
}
