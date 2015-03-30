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
    public static class InitialSetupPreferences
    {
        public static Boolean InitialSetupDone
        {
            get
            {
                return PreferencesHelper.GetBoolean("InitialSetupPreferences_InitialSetupDone");
            }
            set
            {
                PreferencesHelper.SetBoolean("InitialSetupPreferences_InitialSetupDone", value);
            }
        }
    }
}
