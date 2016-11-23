using Android.App;
using Android.Content;
using Flash_It.Droid.Preferences;
using Flash_It.Droid.Utils;
using Flash_It.Droid.Bootstrap;
using Autofac;
using System.Threading.Tasks;

namespace Flash_It.Droid.IntentServices
{
    [Service]
    public class SmsIntentService : IntentService
    {
		private readonly BatteryUtil _battery;
		private readonly CameraUtil _camera;
		private readonly RingerUtil _ringer;

		public SmsIntentService()
		{
			_battery = App.Container.Resolve<BatteryUtil>();
			_camera = App.Container.Resolve<CameraUtil>();
			_ringer = App.Container.Resolve<RingerUtil>();
		}

        protected override async void OnHandleIntent(Intent intent)
        {
			if (SmsPreferences.Enabled && _battery.CheckBatteryLevelAllowed() && _ringer.CheckIfProfileIsAllowed())
            {
                for (int i = 1; i <= SmsPreferences.NumberOfTimes; i++)
                {
                    _camera.Flash(SmsPreferences.OnTime);
                    await Task.Delay(SmsPreferences.OffTime);
                }
            }
        }
    }
}