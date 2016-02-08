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
using Flash_It.Droid.Helpers;
using Flash_It.Droid.Preferences;
using Android.Telephony;

namespace Flash_It.Droid.IntentServices
{
    [Service]
    public class CallIntentService : IntentService
    {
        protected override void OnHandleIntent(Intent intent)
        {
            InitialSetupHelper.CheckInitialSetup();

            if (CallPreferences.Enabled && !RingerHelper.FlashProcessStarted && BatteryHelper.CheckBatteryLevelAllowed() && RingerHelper.CheckIfProfileIsAllowed())
            {
                RingerHelper.FlashProcessStarted = true;

                do
                {
                    CameraHelper.Flash(CallPreferences.OnTime);
                    Thread.Sleep(CallPreferences.OffTime);
                } while (RingerHelper.CurrentRingerState == TelephonyManager.ExtraStateRinging);

                RingerHelper.FlashProcessStarted = false;
            }
        }
    }
}