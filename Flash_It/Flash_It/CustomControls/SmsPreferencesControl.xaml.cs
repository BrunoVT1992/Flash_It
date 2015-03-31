using Flash_It.DependencyServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Flash_It.CustomControls
{
    public partial class SmsPreferencesControl : ContentView
    {
        public SmsPreferencesControl()
        {
            InitializeComponent();

            TitleLabel.Text = "Sms preferences";
            OnTimeTitleLabel.Text = "On time";
            OffTimeTitleLabel.Text = "Off time";
            NumberOfTimesTitleLabel.Text = "Number of times";

            this.BackgroundColor = Color.White.MultiplyAlpha(0.5);

            OnTimeSlider.Value = DependencyService.Get<ISmsPreferences>().GetOnTime();
            OffTimeSlider.Value = DependencyService.Get<ISmsPreferences>().GetOffTime();
            NumberOfTimesSlider.Value = DependencyService.Get<ISmsPreferences>().GetNumberOfTimes();

            EnabledSwitch.IsToggled = DependencyService.Get<ISmsPreferences>().GetEnabled();
        }

        private void NumberOfTimesSlider_ValueChanged(object sender, ValueChangedEventArgs e)
        {
            int value = (int)Math.Ceiling(NumberOfTimesSlider.Value);

            DependencyService.Get<ISmsPreferences>().SetNumberOfTimes(value);

            NumberOfTimesSliderValueLabel.Text = value.ToString();
        }

        private void OffTimeSlider_ValueChanged(object sender, ValueChangedEventArgs e)
        {
            int value = (int)Math.Round(OffTimeSlider.Value / 50) * 50;

            DependencyService.Get<ISmsPreferences>().SetOffTime(value);

            OffTimeSliderValueLabel.Text = value.ToString();
        }

        private void OnTimeSlider_ValueChanged(object sender, ValueChangedEventArgs e)
        {
            int value = (int)Math.Round(OnTimeSlider.Value / 50) * 50;

            DependencyService.Get<ISmsPreferences>().SetOnTime(value);

            OnTimeSliderValueLabel.Text = value.ToString();
        }

        private void EnabledSwitch_Toggled(object sender, ToggledEventArgs e)
        {
            DependencyService.Get<ISmsPreferences>().SetEnabled(EnabledSwitch.IsToggled);
        }
    }
}
