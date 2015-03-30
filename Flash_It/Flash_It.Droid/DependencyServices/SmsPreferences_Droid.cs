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

[assembly: Dependency(typeof(SmsPreferences_Droid))]

namespace Flash_It.Droid.DependencyServices
{
    public class SmsPreferences_Droid : ISmsPreferences
    {
        public bool GetEnabled()
        {
            return SmsPreferences.Enabled;
        }

        public int GetNumberOfTimes()
        {
            return SmsPreferences.NumberOfTimes;
        }

        public int GetOffTime()
        {
            return SmsPreferences.OffTime;
        }

        public int GetOnTime()
        {
            return SmsPreferences.OnTime;
        }

        public void SetEnabled(bool enabled)
        {
            SmsPreferences.Enabled = enabled;
        }

        public void SetNumberOfTimes(int numberOfTimes)
        {
            SmsPreferences.NumberOfTimes = numberOfTimes;
        }

        public void SetOffTime(int offTime)
        {
            SmsPreferences.OffTime = offTime;
        }

        public void SetOnTime(int onTime)
        {
            SmsPreferences.OnTime = onTime;
        }
    }
}