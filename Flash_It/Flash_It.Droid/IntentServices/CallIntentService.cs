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
using System.Threading;
using Flash_It.Helpers;
using Flash_It.Droid.Helpers;
using Flash_It.Droid.Preferences;

namespace Flash_It.Droid.IntentServices
{
    [Service]
    public class CallIntentService : IntentService
    {
        protected override void OnHandleIntent(Intent intent)
        {
            Flash_It.Droid.Helpers.InitialSetupHelper.CheckInitialSetup();

            
            if (CallPreferences.Enabled && !CallHelper.CH.FlashProcessStarted && BatteryHelper.CheckBatteryLevelAllowed() && RingerHelper.CheckIfProfileIsAllowed())
            {
                CallHelper.CH.FlashProcessStarted = true;

                do
                {
                    CameraHelper.Flash(CallPreferences.OnTime);
                    Thread.Sleep(CallPreferences.OffTime);
                } while (CallHelper.CH.CallState == Enums.CallState.Ringing);

                CallHelper.CH.FlashProcessStarted = false;
            }
        }
    }
}