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

namespace Flash_It.Droid
{
    public class Test_Droid : ITest
    {
        public string GetText()
        {
            return "autofac test bruno";
        }
    }
}