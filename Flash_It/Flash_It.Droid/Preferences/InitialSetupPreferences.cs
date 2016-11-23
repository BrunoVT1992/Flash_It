using Flash_It.Droid.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Flash_It.Droid.Preferences
{
    public static class InitialSetupPreferences
    {
        public static Boolean InitialSetupDone
        {
            get
            {
                return Helpers.Preference.GetBoolean("InitialSetupPreferences_InitialSetupDone");
            }
            set
            {
                Helpers.Preference.SetBoolean("InitialSetupPreferences_InitialSetupDone", value);
            }
        }
    }
}
