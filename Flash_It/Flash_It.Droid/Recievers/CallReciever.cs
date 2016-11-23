using System;
using Android.App;
using Android.Content;
using Android.Telephony;
using Android.Support.V4.Content;
using Flash_It.Droid.IntentServices;

namespace Flash_It.Droid.Recievers
{
    [BroadcastReceiver(Enabled = true, Label = "CallListener")]
    [IntentFilter(new string[] { "android.intent.action.PHONE_STATE" }, Priority = Int32.MaxValue)]
    public class CallReciever : WakefulBroadcastReceiver
    {
        public override void OnReceive(Context context, Intent intent)
        {
            if (TelephonyManager.ExtraStateRinging == intent.GetStringExtra(TelephonyManager.ExtraState))
            {
                RingerUtil.CurrentRingerState = TelephonyManager.ExtraStateRinging;

                Intent service = new Intent(context, typeof(CallIntentService));
                StartWakefulService(context, service);
            }

            if (TelephonyManager.ExtraStateOffhook == intent.GetStringExtra(TelephonyManager.ExtraState))
            {
                RingerUtil.CurrentRingerState = TelephonyManager.ExtraStateRinging;
            }

            if (TelephonyManager.ExtraStateIdle == intent.GetStringExtra(TelephonyManager.ExtraState))
            {
                RingerUtil.CurrentRingerState = TelephonyManager.ExtraStateRinging;
            }
        }
    }
}