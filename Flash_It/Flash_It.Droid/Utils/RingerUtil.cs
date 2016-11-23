using System;
using Android.App;
using Android.Content;
using Android.Media;
using Flash_It.Droid.Preferences;

namespace Flash_It.Droid.Utils
{
    public class RingerUtil
    {
        public bool FlashInProgress { get; set; }
		public CallState CallState { get; private set; }

        public Boolean CheckIfProfileIsAllowed()
        {
            Boolean allowed = false;
            AudioManager am = (AudioManager)Application.Context.GetSystemService(Context.AudioService);

            switch (am.RingerMode)
            {
                case RingerMode.Normal:
                    allowed = RingerPreferences.NormalModeEnabled;
                    break;
                case RingerMode.Vibrate:
                    allowed = RingerPreferences.VibrateModeEnabled;
                    break;
                case RingerMode.Silent:
                    allowed = RingerPreferences.SilentModeEnabled;
                    break;
                default:
                    allowed = true;
                    break;
            }

            return allowed;
        }

		public void SetCallState(CallState state)
		{
			CallState = state;
		}
    }
}