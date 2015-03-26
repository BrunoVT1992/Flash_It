using Flash_It.Enums;
using Flash_It.Helpers;
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

            do
            {
                CameraHelper.Flash(400);
                await Task.Delay(300);
            } while (_callState == CallState.Ringing);

            _flashProcessStarted = false;
        }
    }
}
