using System;
using Android.App;
using Android.Content;
using Android.Provider;
using Android.Support.V4.Content;
using Flash_It.Droid.IntentServices;

namespace Flash_It.Droid.Recievers
{
    [BroadcastReceiver(Enabled = true, Label = "TextMessageListener")]
    [IntentFilter(new [] { "android.provider.Telephony.SMS_RECEIVED" }, Priority = Int32.MaxValue)]
    public class TextMessageReciever : WakefulBroadcastReceiver
    {
        public override void OnReceive(Context context, Intent intent)
        {
            if (Telephony.Sms.Intents.SmsReceivedAction == intent.Action)
            {
                Intent service = new Intent(context, typeof(SmsIntentService));
                StartWakefulService(context, service);
            }
        }
    }
}