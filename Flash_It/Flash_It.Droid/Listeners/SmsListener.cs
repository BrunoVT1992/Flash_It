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
using Android.Provider;
using System.Diagnostics;
using Debug = System.Diagnostics.Debug;
using Flash_It.Helpers;
using Java.Lang;

namespace Flash_It.Droid.Listeners
{
    [BroadcastReceiver(Enabled = true, Label = "SMSListener")]
    [IntentFilter(new string[] { "android.provider.Telephony.SMS_RECEIVED" }, Priority = 2147483647)]

    public class SmsListener : BroadcastReceiver
    {
        public override void OnReceive(Context context, Intent intent)
        {
            PowerManager.WakeLock sWakeLock;
            var pm = PowerManager.FromContext(context);
            sWakeLock = pm.NewWakeLock(WakeLockFlags.Partial, "SMSListener");
            sWakeLock.Acquire();

            if (Telephony.Sms.Intents.SmsReceivedAction == intent.Action)
            {
                CameraHelper.Flash(500);
                Thread.Sleep(250);
                CameraHelper.Flash(500);
                Thread.Sleep(250);
                CameraHelper.Flash(500);
                Thread.Sleep(250);
            }

            sWakeLock.Release();
        }
    }
}