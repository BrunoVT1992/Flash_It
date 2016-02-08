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
using System.Threading;
using Android.Hardware;
using System.Diagnostics;
using Flash_It.Droid.Helpers;
using Flash_It.Droid.Preferences;

namespace Flash_It.Droid.IntentServices
{
    [Service]
    public class SmsIntentService : IntentService
    {
        protected override void OnHandleIntent(Intent intent)
        {
            InitialSetupHelper.CheckInitialSetup();

            if (SmsPreferences.Enabled && BatteryHelper.CheckBatteryLevelAllowed() && RingerHelper.CheckIfProfileIsAllowed())
            {
                for (int i = 1; i <= SmsPreferences.NumberOfTimes; i++)
                {
                    CameraHelper.Flash(SmsPreferences.OnTime);
                    Thread.Sleep(SmsPreferences.OffTime);
                }
            }
        }
    }
}