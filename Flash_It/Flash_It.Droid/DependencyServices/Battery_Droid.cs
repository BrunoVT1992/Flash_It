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
using Flash_It.Droid.Helpers;
using Xamarin.Forms;
using Flash_It.Droid.DependencyServices;

[assembly: Dependency(typeof(Battery_Droid))]

namespace Flash_It.Droid.DependencyServices
{
    public class Battery_Droid : IBattery
    {
        public int GetBatteryLevel()
        {
            return BatteryHelper.GetBatteryLevel();
        }
    }
}