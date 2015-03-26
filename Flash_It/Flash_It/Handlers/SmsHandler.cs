using Flash_It.Helpers;
using Flash_It.Preferences;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Flash_It.Handlers
{
    public class SmsHandler
    {
        public SmsHandler() { }

        static volatile SmsHandler _SH;
        static object _SyncRoot = new Object();
        public static SmsHandler SH
        {
            get
            {
                if (_SH == null)
                {
                    lock (_SyncRoot)
                    {
                        if (_SH == null)
                        {
                            _SH = new SmsHandler();
                        }
                    }
                }

                return _SH;
            }
        }

        public async Task SmsRecieved()
        {
            if (SmsPreferences.Enabled)
            {
                for (int i = 1; i <= SmsPreferences.NumberOffTimes; i++)
                {
                    CameraHelper.Flash(SmsPreferences.OnTime);
                    await Task.Delay(SmsPreferences.OffTime);
                }
            }
        }
    }
}
