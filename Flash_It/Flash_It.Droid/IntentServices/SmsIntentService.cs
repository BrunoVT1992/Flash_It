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
using Flash_It.Preferences;
using Flash_It.Helpers;
using System.Threading;
using Android.Hardware;
using System.Diagnostics;

namespace Flash_It.Droid.IntentServices
{
    [Service]
    public class SmsIntentService : IntentService
    {
        protected override void OnHandleIntent(Intent intent)
        {
            Flash(500);

            InitialSetupHelper.CheckInitialSetup();

            if (SmsPreferences.Enabled)
            {
                for (int i = 1; i <= SmsPreferences.NumberOffTimes; i++)
                {
                    CameraHelper.Flash(SmsPreferences.OnTime);
                    Thread.Sleep(SmsPreferences.OffTime);
                }
            }
        }

        public void Flash(int flashDuration)
        {
            try
            {
                var camera = Camera.Open();
                var parameters = camera.GetParameters();
                var supportedFlashModes = camera.GetParameters().SupportedFlashModes;

                var flashMode = string.Empty;
                if (supportedFlashModes.Contains(Camera.Parameters.FlashModeTorch))
                {
                    flashMode = Camera.Parameters.FlashModeTorch;
                }
                else if (supportedFlashModes.Contains(Camera.Parameters.FlashModeOn))
                {
                    flashMode = Camera.Parameters.FlashModeOn;
                }

                if (!string.IsNullOrEmpty(flashMode))
                {
                    parameters.FlashMode = flashMode;
                    camera.SetParameters(parameters);
                    camera.StartPreview();

                    Thread.Sleep(flashDuration);
                }

                parameters.FlashMode = Camera.Parameters.FlashModeOff;
                camera.SetParameters(parameters);
                camera.StopPreview();
                camera.Release();
                camera.Dispose();
            }
            catch (Exception ex)
            {
                //if (Debugger.IsAttached)
                //{
                //    Debug.WriteLine(ex.ToString());
                //}
            }
        }
    }
}