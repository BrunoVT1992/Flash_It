using Android.Hardware;
using System.Threading;
using System;

namespace Flash_It.Droid.Utils
{
    public class CameraUtil
    {
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
				Console.WriteLine(ex.ToString());
            }
        }
    }
}