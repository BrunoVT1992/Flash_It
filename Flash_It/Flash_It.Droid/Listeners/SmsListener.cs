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

//[assembly: UsesPermission(Name = "android.permission.WAKE_LOCK")]
//[assembly: UsesPermission(Name = "android.permission.RECEIVE_SMS")]

namespace Flash_It.Droid.Listeners
{
    [BroadcastReceiver(Enabled = true, Label = "SmsListener")]
    [IntentFilter(new [] { "android.provider.Telephony.SMS_RECEIVED" }, Priority = Int32.MaxValue)]

    public class SmsListener : BroadcastReceiver
    {
        public override void OnReceive(Context context, Intent intent)
        {
            //PowerManager.WakeLock sWakeLock;
            //var pm = PowerManager.FromContext(context);
            //sWakeLock = pm.NewWakeLock(WakeLockFlags.Partial, "SMSListener");
            //sWakeLock.Acquire();

            Toast.MakeText(context, "recieved", ToastLength.Long).Show();

            if (Telephony.Sms.Intents.SmsReceivedAction == intent.Action)
            {
                new Thread(new Runnable(() => {
                    Flash(500);
                    Thread.Sleep(250);
                    Flash(500);
                })).Start();
            }

            //sWakeLock.Release();
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
            catch (System.Exception ex)
            {
                if (Debugger.IsAttached)
                {
                    Debug.WriteLine(ex.ToString());
                }
            }
        }
    }
}