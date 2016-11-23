using Android.App;
using Android.Content;
using Flash_It.Droid.Preferences;
using Android.Telephony;
using Flash_It.Droid.Utils;
using Flash_It.Droid.Bootstrap;
using Autofac;
using System.Threading.Tasks;

namespace Flash_It.Droid.IntentServices
{
    [Service]
    public class CallIntentService : IntentService
    {
		private readonly RingerUtil _ringer;
		private readonly BatteryUtil _battery;
		private readonly CameraUtil _camera;

		public CallIntentService()
		{
			_ringer = App.Container.Resolve<RingerUtil>();
			_battery = App.Container.Resolve<BatteryUtil>();
			_camera = App.Container.Resolve<CameraUtil>();
		}

        protected async override void OnHandleIntent(Intent intent)
        {
            if (CallPreferences.Enabled && !_ringer.FlashProcessStarted && _battery.CheckBatteryLevelAllowed() && _ringer.CheckIfProfileIsAllowed())
            {
                _ringer.FlashProcessStarted = true;

                do
                {
					_camera.Flash(CallPreferences.OnTime);
					await Task.Delay(CallPreferences.OffTime);
                } while (_ringer.CurrentRingerState == TelephonyManager.ExtraStateRinging);

                _ringer.FlashProcessStarted = false;
            }
        }
    }
}