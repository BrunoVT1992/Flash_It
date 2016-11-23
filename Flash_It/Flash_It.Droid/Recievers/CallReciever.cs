using System;
using Android.App;
using Android.Content;
using Android.Telephony;
using Android.Support.V4.Content;
using Flash_It.Droid.Utils;
using Flash_It.Droid.Bootstrap;
using Autofac;
using Flash_It.Droid.Services;

namespace Flash_It.Droid.Recievers
{
	[BroadcastReceiver(Enabled = true, Label = "CallListener")]
	[IntentFilter(new string[] { "android.intent.action.PHONE_STATE" }, Priority = Int32.MaxValue)]
	public class CallReciever : WakefulBroadcastReceiver
	{
		private readonly RingerUtil _ringer;

		public CallReciever()
		{
			_ringer = App.Container.Resolve<RingerUtil>();
		}

		public override void OnReceive(Context context, Intent intent)
		{
			if (TelephonyManager.ExtraStateRinging == intent.GetStringExtra(TelephonyManager.ExtraState))
			{
				_ringer.SetCallState(CallState.Ringing);

				var service = new Intent(context, typeof(CallIntentService));
				StartWakefulService(context, service);
			}

			if (TelephonyManager.ExtraStateOffhook == intent.GetStringExtra(TelephonyManager.ExtraState))
			{
				_ringer.SetCallState(CallState.Answered);
			}

			if (TelephonyManager.ExtraStateIdle == intent.GetStringExtra(TelephonyManager.ExtraState))
			{
				_ringer.SetCallState(CallState.Idle);
			}
		}
	}
}