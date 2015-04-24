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
using Android.Support.V4.Content;
using Flash_It.Droid.IntentServices;
using Flash_It.Droid.Helpers;

namespace Flash_It.Droid.Recievers
{
    [BroadcastReceiver(Enabled = true, Label = "SmsListener")]
    [IntentFilter(new [] { "android.provider.Telephony.SMS_RECEIVED" }, Priority = Int32.MaxValue)]
    public class SmsReciever : WakefulBroadcastReceiver
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