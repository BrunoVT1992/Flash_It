using Flash_It.DependencyServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Flash_It.Preferences
{
    public static class InitialSetupPreferences
    {
        public static Boolean InitialSetupDone
        {
            get
            {
                return DependencyService.Get<IPreferences>().GetBoolean("InitialSetupPreferences_InitialSetupDone");
            }
            set
            {
                DependencyService.Get<IPreferences>().SetBoolean("InitialSetupPreferences_InitialSetupDone", value);
            }
        }
    }
}
