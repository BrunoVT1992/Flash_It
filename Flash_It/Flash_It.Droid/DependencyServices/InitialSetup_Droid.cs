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
using Flash_It.Droid.DependencyServices;
using Xamarin.Forms;

[assembly: Dependency(typeof(InitialSetup_Droid))]

namespace Flash_It.Droid.DependencyServices
{
    public class InitialSetup_Droid : IInitialSetup
    {
        public void CheckInitialSetup()
        {
            InitialSetupHelper.CheckInitialSetup();
        }
    }
}