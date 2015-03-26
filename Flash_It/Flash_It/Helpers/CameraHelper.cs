using Flash_It.DependencyServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using System.Threading;

namespace Flash_It.Helpers
{
    public static class CameraHelper
    {
        public static void Flash(int flashDuration)
        {
            DependencyService.Get<ICamera>().Flash(flashDuration);
        }
    }
}
