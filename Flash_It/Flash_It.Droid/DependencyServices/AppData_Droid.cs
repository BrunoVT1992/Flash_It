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
using Xamarin.Forms;
using Application = Android.App.Application;
using Java.Util;
using Flash_It.Droid.DependencyServices;

[assembly: Dependency(typeof(AppData_Droid))]

namespace Flash_It.Droid.DependencyServices
{
    public class AppData_Droid : IAppData
    {
        public string GetAppVersion()
        {
            return Application.Context.PackageManager.GetPackageInfo(Application.Context.PackageName, 0).VersionName;
        }

        public string GetSystemCulture()
        {
            var androidLocale = Locale.Default;

            var netLanguage = androidLocale.ToString().Replace("_", "-");

            if (netLanguage.Contains("-"))
            {
                netLanguage = netLanguage.Split('-')[1];
            }

            return netLanguage;
        }

        public string GetSystemLanguage()
        {
            var androidLocale = Locale.Default;

            var netLocale = androidLocale.ToString().Replace("_", "-");

            if (netLocale.Contains("-"))
            {
                netLocale = netLocale.Split('-')[0];
            }

            return netLocale;
        }
    }
}