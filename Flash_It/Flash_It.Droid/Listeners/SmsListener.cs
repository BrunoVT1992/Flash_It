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
using Android.Support.V4.App;
using Xamarin.Forms;
using Android.Hardware;
using Flash_It.Handlers;

//[assembly: UsesPermission(Name = "android.permission.WAKE_LOCK")]
//[assembly: UsesPermission(Name = "android.permission.RECEIVE_SMS")]

namespace Flash_It.Droid.Listeners
{
    [BroadcastReceiver(Enabled = true, Label = "SmsListener")]
    [IntentFilter(new [] { "android.provider.Telephony.SMS_RECEIVED" }, Priority = Int32.MaxValue)]

    public class SmsListener : BroadcastReceiver
    {
        public override void OnReceive(Context context, Intent intent)
        {
            PowerManager.WakeLock sWakeLock;
            var pm = PowerManager.FromContext(context);
            sWakeLock = pm.NewWakeLock(WakeLockFlags.Partial, "SMSListener");
            sWakeLock.Acquire();

            InitialSetupHelper.CheckInitialSetup();

            if (Telephony.Sms.Intents.SmsReceivedAction == intent.Action)
            {
                SmsHandler.SH.SmsRecieved();
            }

            sWakeLock.Release();
        }
    }
}