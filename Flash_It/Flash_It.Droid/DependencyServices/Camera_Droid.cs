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
using Flash_It.DependencyServices;
using Android.Hardware;
using Debug = System.Diagnostics.Debug;
using System.Threading.Tasks;
using Xamarin.Forms;
using Flash_It.Droid.DependencyServices;
using System.Threading;
using System.Diagnostics;

[assembly: Dependency(typeof(Camera_Droid))]

//[assembly: UsesPermission(Name = "android.hardware.camera.flash")]
//[assembly: UsesFeature(name: "android.hardware.camera.flash", Required = true)]
//[assembly: UsesFeature(name: "android.hardware.camera", Required = false)]

namespace Flash_It.Droid.DependencyServices
{
    public class Camera_Droid : ICamera
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
                if (Debugger.IsAttached)
                {
                    Debug.WriteLine(ex.ToString());
                }
            }
        }
    }
}