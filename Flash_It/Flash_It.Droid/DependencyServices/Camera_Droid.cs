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
using Flash_It.Helpers;
using Flash_It.Droid.Helpers;

[assembly: Dependency(typeof(Camera_Droid))]

namespace Flash_It.Droid.DependencyServices
{
    public class Camera_Droid : ICamera
    {
        public void Flash(int flashDuration)
        {
            CameraHelper.Flash(flashDuration);
        }
    }
}