using Flash_It.DependencyServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Flash_It.Preferences
{
    public static class CallPreferences
    {
        public static Boolean Enabled
        {
            get
            {
                return DependencyService.Get<IPreferences>().GetBoolean("CallPreferences_Enabled");
            }
            set
            {
                DependencyService.Get<IPreferences>().SetBoolean("CallPreferences_Enabled", value);
            }
        }

        public static int OnTime
        {
            get
            {
                return DependencyService.Get<IPreferences>().GetInt("CallPreferences_OnTime");
            }
            set
            {
                DependencyService.Get<IPreferences>().SetInt("CallPreferences_OnTime", value);
            }
        }

        public static int OffTime
        {
            get
            {
                return DependencyService.Get<IPreferences>().GetInt("CallPreferences_OffTime");
            }
            set
            {
                DependencyService.Get<IPreferences>().SetInt("CallPreferences_OffTime", value);
            }
        }
    }
}
