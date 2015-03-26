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
using Debug = System.Diagnostics.Debug;
using Android.Telephony;
using Flash_It.Handlers;

namespace Flash_It.Droid.Listeners
{
    [BroadcastReceiver(Enabled = true, Label = "CallListener")]
    [IntentFilter(new string[] { "android.intent.action.PHONE_STATE" }, Priority = 2147483647)]

    public class CallListener : BroadcastReceiver
    {
        public override void OnReceive(Context context, Intent intent)
        {
            if (TelephonyManager.ExtraStateRinging == intent.GetStringExtra(TelephonyManager.ExtraState))
            {
                CallHandler.CH.CallState = Enums.CallState.Ringing;
            }

            if (TelephonyManager.ExtraStateOffhook == intent.GetStringExtra(TelephonyManager.ExtraState))
            {
                CallHandler.CH.CallState = Enums.CallState.OffHook;
            }

            if (TelephonyManager.ExtraStateIdle == intent.GetStringExtra(TelephonyManager.ExtraState))
            {
                CallHandler.CH.CallState = Enums.CallState.Idle;
            }
        }
    }
}