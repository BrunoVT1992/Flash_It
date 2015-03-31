using Flash_It.DependencyServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Flash_It.CustomControls
{
    public partial class CallPreferencesControl : ContentView
    {
        public CallPreferencesControl()
        {
            InitializeComponent();

            TitleLabel.Text = "Call preferences";
            OnTimeTitleLabel.Text = "On time";
            OffTimeTitleLabel.Text = "Off time";

            this.BackgroundColor = Color.White.MultiplyAlpha(0.5);

            OnTimeSlider.Value = DependencyService.Get<ICallPreferences>().GetOnTime();
            OffTimeSlider.Value = DependencyService.Get<ICallPreferences>().GetOffTime();

            EnabledSwitch.IsToggled = DependencyService.Get<ICallPreferences>().GetEnabled();
        }

        private void OffTimeSlider_ValueChanged(object sender, ValueChangedEventArgs e)
        {
            int value = (int)Math.Round(OffTimeSlider.Value / 50) * 50;

            DependencyService.Get<ICallPreferences>().SetOffTime(value);

            OffTimeSliderValueLabel.Text = value.ToString();
        }

        private void OnTimeSlider_ValueChanged(object sender, ValueChangedEventArgs e)
        {
            int value = (int)Math.Round(OnTimeSlider.Value / 50) * 50;

            DependencyService.Get<ICallPreferences>().SetOnTime(value);

            OnTimeSliderValueLabel.Text = value.ToString();
        }

        private void EnabledSwitch_Toggled(object sender, ToggledEventArgs e)
        {
            DependencyService.Get<ICallPreferences>().SetEnabled(EnabledSwitch.IsToggled);
        }
    }
}
