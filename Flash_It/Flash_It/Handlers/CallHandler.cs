using Flash_It.Enums;
using Flash_It.Helpers;
using Flash_It.Preferences;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Flash_It.Handlers
{
    public class CallHandler
    {
        public CallHandler() { }

        static volatile CallHandler _CH;
        static object _SyncRoot = new Object();
        public static CallHandler CH
        {
            get
            {
                if (_CH == null)
                {
                    lock (_SyncRoot)
                    {
                        if (_CH == null)
                        {
                            _CH = new CallHandler();
                        }
                    }
                }

                return _CH;
            }
        }

        private CallState _callState;
        public CallState CallState
        {
            get
            {
                return _callState;
            }
            set
            {
                _callState = value;

                if (_callState == CallState.Ringing)
                {
                    if (!_flashProcessStarted)
                    {
                        _recievingCall();
                    }
                }
            }
        }

        private Boolean _flashProcessStarted;

        private async Task _recievingCall()
        {
            _flashProcessStarted = true;

            if (CallPreferences.Enabled)
            {
                do
                {
                    CameraHelper.Flash(CallPreferences.OnTime);
                    await Task.Delay(CallPreferences.OffTime);
                } while (_callState == CallState.Ringing);
            }

            _flashProcessStarted = false;
        }
    }
}
