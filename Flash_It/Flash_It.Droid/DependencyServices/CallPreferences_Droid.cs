using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Flash_It.DependencyServices;
using Flash_It.Droid.Preferences;
using Flash_It.Droid.DependencyServices;
using Xamarin.Forms;

[assembly: Dependency(typeof(CallPreferences_Droid))]

namespace Flash_It.Droid.DependencyServices
{
    public class CallPreferences_Droid : ICallPreferences
    {
        public bool GetEnabled()
        {
            return CallPreferences.Enabled;
        }

        public int GetOffTime()
        {
            return CallPreferences.OffTime;
        }

        public int GetOnTime()
        {
            return CallPreferences.OnTime;
        }

        public void SetEnabled(bool enabled)
        {
            CallPreferences.Enabled = enabled;
        }

        public void SetOffTime(int offTime)
        {
            CallPreferences.OffTime = offTime;
        }

        public void SetOnTime(int onTime)
        {
            CallPreferences.OnTime = onTime;
        }
    }
}