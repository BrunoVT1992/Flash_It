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
using Flash_It.Preferences;
using Flash_It.Helpers;
using System.Threading;

namespace Flash_It.Droid.IntentServices
{
    [Service]
    public class SmsIntentService : IntentService
    {
        protected override void OnHandleIntent(Intent intent)
        {
            InitialSetupHelper.CheckInitialSetup();

            if (SmsPreferences.Enabled)
            {
                for (int i = 1; i <= SmsPreferences.NumberOffTimes; i++)
                {
                    CameraHelper.Flash(SmsPreferences.OnTime);
                    Thread.Sleep(SmsPreferences.OffTime);
                }
            }
        }
    }
}