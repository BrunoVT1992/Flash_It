using Flash_It.Helpers;
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
            CameraHelper.Flash(200);
            await Task.Delay(200);
            CameraHelper.Flash(200);
        }
    }
}
