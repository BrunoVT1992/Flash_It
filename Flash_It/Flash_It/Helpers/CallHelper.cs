using Flash_It.Helpers;
using Flash_It.Preferences;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Flash_It.Helpers
{
    public class CallHelper
    {
        public CallHelper() { }

        static volatile CallHelper _CH;
        static object _SyncRoot = new Object();
        public static CallHelper CH
        {
            get
            {
                if (_CH == null)
                {
                    lock (_SyncRoot)
                    {
                        if (_CH == null)
                        {
                            _CH = new CallHelper();
                        }
                    }
                }

                return _CH;
            }
        }

        public string CallState { get; set; }

        public Boolean FlashProcessStarted { get; set; }
    }
}
