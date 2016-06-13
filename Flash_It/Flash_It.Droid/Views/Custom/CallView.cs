using Android.Content;
using Android.Util;
using Android.Widget;

namespace Flash_It.Droid.Views.Custom
{
    public class CallView : FrameLayout
    {
        public CallView(Context context, IAttributeSet attrs) : 
            base(context, attrs)
        {
            var view = Inflate(context, Resource.Layout.ViewCall, this);
        }
    }
}