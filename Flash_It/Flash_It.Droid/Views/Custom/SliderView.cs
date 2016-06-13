using System;
using Android.Content;
using Android.Util;
using Android.Widget;

namespace Flash_It.Droid.Views.Custom
{
    public class SliderView : FrameLayout
    {
        private TextView _title;
        private TextView _text;
        private SeekBar _slider;

        public string Title => _title.Text;
        public string Text => _text.Text;
        public int MaxValue { get; set; } = 100;
        public int MinValue { get; set; } = 0;

        public event EventHandler<int> ProgressChanged;

        public SliderView(Context context, IAttributeSet attrs)
            : base(context, attrs)
        {
            var view = Inflate(context, Resource.Layout.ViewSlider, this);

            _title = view.FindViewById<TextView>(Resource.Id.TextView_ViewSlider_Title);
            _text = view.FindViewById<TextView>(Resource.Id.TextView_ViewSlider_Text);
            _slider = view.FindViewById<SeekBar>(Resource.Id.SeekBar_ViewSlider);

            _slider.ProgressChanged += (s, e) =>
            {
                //var range = MaxValue - MinValue;
                //var value = (range / 100) * e.Progress;

                //ProgressChanged?.Invoke(this, value);
            };
        }
    }
}