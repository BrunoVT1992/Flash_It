using Flash_It.DependencyServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Flash_It.Preferences
{
    public static class SmsPreferences
    {
        public static Boolean Enabled
        {
            get
            {
                return DependencyService.Get<IPreferences>().GetBoolean("InitialSetupPreferences_Enabled");
            }
            set
            {
                DependencyService.Get<IPreferences>().SetBoolean("InitialSetupPreferences_Enabled", value);
            }
        }

        public static int OnTime
        {
            get
            {
                return DependencyService.Get<IPreferences>().GetInt("SmsPreferences_OnTime");
            }
            set
            {
                DependencyService.Get<IPreferences>().SetInt("SmsPreferences_OnTime", value);
            }
        }

        public static int OffTime
        {
            get
            {
                return DependencyService.Get<IPreferences>().GetInt("SmsPreferences_OffTime");
            }
            set
            {
                DependencyService.Get<IPreferences>().SetInt("SmsPreferences_OffTime", value);
            }
        }

        public static int NumberOffTimes
        {
            get
            {
                return DependencyService.Get<IPreferences>().GetInt("SmsPreferences_NumberOffTimes");
            }
            set
            {
                DependencyService.Get<IPreferences>().SetInt("SmsPreferences_NumberOffTimes", value);
            }
        }
    }
}
